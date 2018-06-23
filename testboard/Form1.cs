using ZedGraph;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace testboard
{
    public partial class Form1 : Form
    {
        private const int STEP = 25;

        private const String SIGNAL1 = "AcGy";
        private const String SIGNAL2 = "CH01";
        private const String SIGNAL3 = "CH05";
        private const String SIGNAL4 = "RGB~";
        private const String SIGNAL5 = "IrY~";

        private static readonly String[] SIGNALS = { SIGNAL1, SIGNAL2, SIGNAL3, SIGNAL4, SIGNAL5 };

        private Dictionary<string, long> counter = new Dictionary<string, long>();
        private Dictionary<string, long> cursor  = new Dictionary<string, long>();
        private Dictionary<string, FileWriter> fWriter = new Dictionary<string, FileWriter>();
        private Dictionary<string, ZedGraphControl[]> graph = new Dictionary<string, ZedGraphControl[]>();

        private System.IO.Ports.SerialPort serialPort = new System.IO.Ports.SerialPort();
        
        public Form1()
        {
            InitializeComponent();
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            foreach (String signal in SIGNALS)
            {
                counter[signal] = 0;
                cursor[signal] = 0;
                fWriter[signal] = new FileWriter(GetCurrentTime(), signal);
            }
        }

        // 시리얼포트 정의
        private SerialPort _Port;
        private SerialPort Port
        {
            get
            {
                if (_Port == null)
                {
                    _Port = new SerialPort();
                    _Port.PortName = "COM3";
                    _Port.BaudRate = 921600;
                    _Port.ReadTimeout = 50;
                }
                return _Port;
            }
        }
        private Boolean IsOpen
        {
            get { return Port.IsOpen; }
            set
            {
                if (value)
                {
                    btnConnect.Text = "Disconnect";
                    gbSettings.Enabled = false;
                }
                else
                {
                    btnConnect.Text = "Connect";
                    gbSettings.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 시리얼포트 목록 갱신
            cbPort.DataSource = SerialPort.GetPortNames();

            // 기타 셋팅 목록 기본값 선택
            cbBaudRate.SelectedIndex = 0;

            // 그래프 초기화
            graph[SIGNAL1] = new ZedGraphControl[6] {
                graphAccX,
                graphAccY,
                graphAccZ,
                graphGyroX,
                graphGyroY,
                graphGyroZ
            };
            graph[SIGNAL2] = new ZedGraphControl[8] {
                graphBn1Ch1,
                graphBn1Ch2,
                graphBn1Ch3,
                graphBn1Ch4,
                graphBn1Ch5,
                graphBn1Ch6,
                graphBn1Ch7,
                graphBn1Ch8
            };
            graph[SIGNAL3] = new ZedGraphControl[8] {
                graphBn2Ch1,
                graphBn2Ch2,
                graphBn2Ch3,
                graphBn2Ch4,
                graphBn2Ch5,
                graphBn2Ch6,
                graphBn2Ch7,
                graphBn2Ch8
            };
            graph[SIGNAL4] = new ZedGraphControl[4] {
                graphRed,
                graphGreen,
                graphBlue,
                graphAmb0
            };
            graph[SIGNAL5] = new ZedGraphControl[4] {
                graphIr,
                graphYellow1,
                graphYellow2,
                graphAmb1
            };

            InitializeGraph(graph[SIGNAL1]);
            InitializeGraph(graph[SIGNAL2]);
            InitializeGraph(graph[SIGNAL3]);
            InitializeGraph(graph[SIGNAL4]);
            InitializeGraph(graph[SIGNAL5]);

        }

        private String ReadLine()
        {
            return Port.ReadLine().Trim();
        }

        public bool IsByteError(String Key)
        {
            if (!SIGNALS.Any(Key.Contains))
            {
                return true;
            }
            return false;
        }

        private void DrawGraph(String signal, int[] points)
        {
            if (!CheckStep(signal))
                return;

            this.Invoke(new EventHandler(delegate
            {
                for (int i = 0; i < graph[signal].Length; i++)
                {   // get a reference to the GraphPane
                    GraphPane myPane = graph[signal][i].GraphPane;
                    LineItem curve = myPane.CurveList[0] as LineItem;
                    PointPair point = new PointPair(cursor[signal], points[i]);
                    curve.AddPoint(point);
                    graph[signal][i].AxisChange();
                    graph[signal][i].Invalidate();
                    myPane.XAxis.Scale.Min = Math.Max(0, cursor[signal] - 50);
                    myPane.XAxis.Scale.Max = cursor[signal];
                }
            }));

        }

        private void InitializeGraph(ZedGraphControl[] zgcs)
        {
            foreach (ZedGraphControl zgc in zgcs)
            {
                // get a reference to the GraphPane
                GraphPane myPane = zgc.GraphPane;

                // Set default settings
                //myPane.YAxis.Scale.Min = 0;
                //myPane.YAxis.Scale.Max = 10000;

                myPane.XAxis.IsVisible = false;
                myPane.YAxis.IsVisible = false;
                myPane.Legend.IsVisible = false;
                myPane.Title.IsVisible = false;

                // Make up some data arrays based on the Sine function
                PointPairList point = new PointPairList();
                LineItem myCurve = myPane.AddCurve("null", point, Color.Red, SymbolType.None);

                // Tell ZedGraph to refigure the axes since the data have changed
                zgc.AxisChange();
            }
        }

        private bool CheckStep(String key)
        {
            counter[key]++;
            if (counter[key] % STEP == 0)
            {
                cursor[key]++;
                return true;
            }
            return false;
        }

        private String[] Tokenizer(String s)
        {
            char[] separater = { ':', '_' };
            return s.Split(separater);
        }

        private int[] Hex2Dec(String[] input)
        {
            int offset = 2; // Signal name, Timestamp
            int len = input.Length - offset;

            String[] hex = new string[len];
            int[] dec = new int[len];

            Array.Copy(input, offset, hex, 0, len);

            for (int i = 0; i < len; i++)
            {
                try
                {
                    dec[i] = Convert.ToInt32(hex[i], 16);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}", "FormatException");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0}", "OverflowException");
                }
                
            }

            return dec;
        }

        private String GetCurrentTime()
        {
            return DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }

        private void Pipeline()
        {
            Console.WriteLine("Thread started");
            while (IsOpen)
            {
                try
                {
                    String line = ReadLine();
                    String[] slices = Tokenizer(line);
                    String sensor = slices[0];

                    if (IsByteError(sensor))
                        continue;

                    int[] values = Hex2Dec(slices);

                    // 그래프 그리기
                    DrawGraph(sensor, values);

                    // 파일 저장
                    fWriter[sensor].WriteLine(values);
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine("Thread ended");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!Port.IsOpen)
            {
                // 현재 시리얼이 연결된 상태가 아니면 연결.
                Port.PortName = cbPort.SelectedItem.ToString();
                Port.BaudRate = Convert.ToInt32(cbBaudRate.SelectedItem);
                try
                {
                    // 포트 연결 후 Pipeline 실행
                    Port.Open();
                    new Thread(new ThreadStart(Pipeline)).Start();
                }
                catch (Exception ex) { String.Format("[ERR] {0}", ex.Message); }
            }
            else
            {
                Port.Close();
                // 현재 시리얼이 연결 상태이면 연결 해제
                CloseFile();
            }
            // 상태 변경
            IsOpen = Port.IsOpen;
        }

        private void CloseFile()
        {
            foreach (String sensor in SIGNALS)
            {
                fWriter[sensor].CloseWriter();
            }
        }

    }

}