namespace testboard
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbAcc = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.graphAccZ = new ZedGraph.ZedGraphControl();
            this.graphAccY = new ZedGraph.ZedGraphControl();
            this.graphAccX = new ZedGraph.ZedGraphControl();
            this.gbGyro = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.graphGyroZ = new ZedGraph.ZedGraphControl();
            this.label16 = new System.Windows.Forms.Label();
            this.graphGyroY = new ZedGraph.ZedGraphControl();
            this.graphGyroX = new ZedGraph.ZedGraphControl();
            this.gbPpg = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.graphAmb1 = new ZedGraph.ZedGraphControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.graphYellow2 = new ZedGraph.ZedGraphControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.graphAmb0 = new ZedGraph.ZedGraphControl();
            this.graphYellow1 = new ZedGraph.ZedGraphControl();
            this.graphBlue = new ZedGraph.ZedGraphControl();
            this.label10 = new System.Windows.Forms.Label();
            this.graphGreen = new ZedGraph.ZedGraphControl();
            this.graphIr = new ZedGraph.ZedGraphControl();
            this.graphRed = new ZedGraph.ZedGraphControl();
            this.gbPressure1 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.graphBn1Ch8 = new ZedGraph.ZedGraphControl();
            this.graphBn1Ch4 = new ZedGraph.ZedGraphControl();
            this.label19 = new System.Windows.Forms.Label();
            this.graphBn1Ch7 = new ZedGraph.ZedGraphControl();
            this.graphBn1Ch3 = new ZedGraph.ZedGraphControl();
            this.label20 = new System.Windows.Forms.Label();
            this.graphBn1Ch6 = new ZedGraph.ZedGraphControl();
            this.graphBn1Ch2 = new ZedGraph.ZedGraphControl();
            this.graphBn1Ch5 = new ZedGraph.ZedGraphControl();
            this.graphBn1Ch1 = new ZedGraph.ZedGraphControl();
            this.gbPressure2 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.graphBn2Ch4 = new ZedGraph.ZedGraphControl();
            this.label26 = new System.Windows.Forms.Label();
            this.graphBn2Ch8 = new ZedGraph.ZedGraphControl();
            this.label27 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.graphBn2Ch3 = new ZedGraph.ZedGraphControl();
            this.label28 = new System.Windows.Forms.Label();
            this.graphBn2Ch7 = new ZedGraph.ZedGraphControl();
            this.graphBn2Ch2 = new ZedGraph.ZedGraphControl();
            this.graphBn2Ch1 = new ZedGraph.ZedGraphControl();
            this.label32 = new System.Windows.Forms.Label();
            this.graphBn2Ch5 = new ZedGraph.ZedGraphControl();
            this.graphBn2Ch6 = new ZedGraph.ZedGraphControl();
            this.gbSettings.SuspendLayout();
            this.gbAcc.SuspendLayout();
            this.gbGyro.SuspendLayout();
            this.gbPpg.SuspendLayout();
            this.gbPressure1.SuspendLayout();
            this.gbPressure2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.cbBaudRate);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.cbPort);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSettings.Location = new System.Drawing.Point(12, 12);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(203, 133);
            this.gbSettings.TabIndex = 2;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "921600"});
            this.cbBaudRate.Location = new System.Drawing.Point(71, 93);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 23);
            this.cbBaudRate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(71, 35);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 23);
            this.cbPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(21, 153);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(183, 50);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbAcc
            // 
            this.gbAcc.Controls.Add(this.label13);
            this.gbAcc.Controls.Add(this.label12);
            this.gbAcc.Controls.Add(this.label11);
            this.gbAcc.Controls.Add(this.graphAccZ);
            this.gbAcc.Controls.Add(this.graphAccY);
            this.gbAcc.Controls.Add(this.graphAccX);
            this.gbAcc.Font = new System.Drawing.Font("Arial", 9F);
            this.gbAcc.Location = new System.Drawing.Point(221, 12);
            this.gbAcc.Name = "gbAcc";
            this.gbAcc.Size = new System.Drawing.Size(429, 197);
            this.gbAcc.TabIndex = 5;
            this.gbAcc.TabStop = false;
            this.gbAcc.Text = "Accelerometer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F);
            this.label13.Location = new System.Drawing.Point(353, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Z";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F);
            this.label12.Location = new System.Drawing.Point(212, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F);
            this.label11.Location = new System.Drawing.Point(71, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "X";
            // 
            // graphAccZ
            // 
            this.graphAccZ.Location = new System.Drawing.Point(288, 19);
            this.graphAccZ.Name = "graphAccZ";
            this.graphAccZ.ScrollGrace = 0D;
            this.graphAccZ.ScrollMaxX = 0D;
            this.graphAccZ.ScrollMaxY = 0D;
            this.graphAccZ.ScrollMaxY2 = 0D;
            this.graphAccZ.ScrollMinX = 0D;
            this.graphAccZ.ScrollMinY = 0D;
            this.graphAccZ.ScrollMinY2 = 0D;
            this.graphAccZ.Size = new System.Drawing.Size(135, 150);
            this.graphAccZ.TabIndex = 6;
            // 
            // graphAccY
            // 
            this.graphAccY.Location = new System.Drawing.Point(147, 19);
            this.graphAccY.Name = "graphAccY";
            this.graphAccY.ScrollGrace = 0D;
            this.graphAccY.ScrollMaxX = 0D;
            this.graphAccY.ScrollMaxY = 0D;
            this.graphAccY.ScrollMaxY2 = 0D;
            this.graphAccY.ScrollMinX = 0D;
            this.graphAccY.ScrollMinY = 0D;
            this.graphAccY.ScrollMinY2 = 0D;
            this.graphAccY.Size = new System.Drawing.Size(135, 150);
            this.graphAccY.TabIndex = 5;
            // 
            // graphAccX
            // 
            this.graphAccX.Location = new System.Drawing.Point(6, 19);
            this.graphAccX.Name = "graphAccX";
            this.graphAccX.ScrollGrace = 0D;
            this.graphAccX.ScrollMaxX = 0D;
            this.graphAccX.ScrollMaxY = 0D;
            this.graphAccX.ScrollMaxY2 = 0D;
            this.graphAccX.ScrollMinX = 0D;
            this.graphAccX.ScrollMinY = 0D;
            this.graphAccX.ScrollMinY2 = 0D;
            this.graphAccX.Size = new System.Drawing.Size(135, 150);
            this.graphAccX.TabIndex = 4;
            // 
            // gbGyro
            // 
            this.gbGyro.Controls.Add(this.label14);
            this.gbGyro.Controls.Add(this.label15);
            this.gbGyro.Controls.Add(this.graphGyroZ);
            this.gbGyro.Controls.Add(this.label16);
            this.gbGyro.Controls.Add(this.graphGyroY);
            this.gbGyro.Controls.Add(this.graphGyroX);
            this.gbGyro.Font = new System.Drawing.Font("Arial", 9F);
            this.gbGyro.Location = new System.Drawing.Point(655, 12);
            this.gbGyro.Name = "gbGyro";
            this.gbGyro.Size = new System.Drawing.Size(429, 197);
            this.gbGyro.TabIndex = 7;
            this.gbGyro.TabStop = false;
            this.gbGyro.Text = "Gyroscope";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F);
            this.label14.Location = new System.Drawing.Point(352, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Z";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10F);
            this.label15.Location = new System.Drawing.Point(211, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Y";
            // 
            // graphGyroZ
            // 
            this.graphGyroZ.Location = new System.Drawing.Point(288, 19);
            this.graphGyroZ.Name = "graphGyroZ";
            this.graphGyroZ.ScrollGrace = 0D;
            this.graphGyroZ.ScrollMaxX = 0D;
            this.graphGyroZ.ScrollMaxY = 0D;
            this.graphGyroZ.ScrollMaxY2 = 0D;
            this.graphGyroZ.ScrollMinX = 0D;
            this.graphGyroZ.ScrollMinY = 0D;
            this.graphGyroZ.ScrollMinY2 = 0D;
            this.graphGyroZ.Size = new System.Drawing.Size(135, 150);
            this.graphGyroZ.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10F);
            this.label16.Location = new System.Drawing.Point(70, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "X";
            // 
            // graphGyroY
            // 
            this.graphGyroY.Location = new System.Drawing.Point(147, 19);
            this.graphGyroY.Name = "graphGyroY";
            this.graphGyroY.ScrollGrace = 0D;
            this.graphGyroY.ScrollMaxX = 0D;
            this.graphGyroY.ScrollMaxY = 0D;
            this.graphGyroY.ScrollMaxY2 = 0D;
            this.graphGyroY.ScrollMinX = 0D;
            this.graphGyroY.ScrollMinY = 0D;
            this.graphGyroY.ScrollMinY2 = 0D;
            this.graphGyroY.Size = new System.Drawing.Size(135, 150);
            this.graphGyroY.TabIndex = 5;
            // 
            // graphGyroX
            // 
            this.graphGyroX.Location = new System.Drawing.Point(6, 19);
            this.graphGyroX.Name = "graphGyroX";
            this.graphGyroX.ScrollGrace = 0D;
            this.graphGyroX.ScrollMaxX = 0D;
            this.graphGyroX.ScrollMaxY = 0D;
            this.graphGyroX.ScrollMaxY2 = 0D;
            this.graphGyroX.ScrollMinX = 0D;
            this.graphGyroX.ScrollMinY = 0D;
            this.graphGyroX.ScrollMinY2 = 0D;
            this.graphGyroX.Size = new System.Drawing.Size(135, 150);
            this.graphGyroX.TabIndex = 4;
            // 
            // gbPpg
            // 
            this.gbPpg.Controls.Add(this.label7);
            this.gbPpg.Controls.Add(this.label6);
            this.gbPpg.Controls.Add(this.graphAmb1);
            this.gbPpg.Controls.Add(this.label5);
            this.gbPpg.Controls.Add(this.label8);
            this.gbPpg.Controls.Add(this.label4);
            this.gbPpg.Controls.Add(this.graphYellow2);
            this.gbPpg.Controls.Add(this.label3);
            this.gbPpg.Controls.Add(this.label9);
            this.gbPpg.Controls.Add(this.graphAmb0);
            this.gbPpg.Controls.Add(this.graphYellow1);
            this.gbPpg.Controls.Add(this.graphBlue);
            this.gbPpg.Controls.Add(this.label10);
            this.gbPpg.Controls.Add(this.graphGreen);
            this.gbPpg.Controls.Add(this.graphIr);
            this.gbPpg.Controls.Add(this.graphRed);
            this.gbPpg.Font = new System.Drawing.Font("Arial", 9F);
            this.gbPpg.Location = new System.Drawing.Point(12, 215);
            this.gbPpg.Name = "gbPpg";
            this.gbPpg.Size = new System.Drawing.Size(1072, 197);
            this.gbPpg.TabIndex = 8;
            this.gbPpg.TabStop = false;
            this.gbPpg.Text = "PPG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(967, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "AMBIENT1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(429, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "AMBIENT0";
            // 
            // graphAmb1
            // 
            this.graphAmb1.Location = new System.Drawing.Point(938, 19);
            this.graphAmb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphAmb1.Name = "graphAmb1";
            this.graphAmb1.ScrollGrace = 0D;
            this.graphAmb1.ScrollMaxX = 0D;
            this.graphAmb1.ScrollMaxY = 0D;
            this.graphAmb1.ScrollMaxY2 = 0D;
            this.graphAmb1.ScrollMinX = 0D;
            this.graphAmb1.ScrollMinY = 0D;
            this.graphAmb1.ScrollMinY2 = 0D;
            this.graphAmb1.Size = new System.Drawing.Size(125, 150);
            this.graphAmb1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(316, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "BLUE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(837, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "YELLOW2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(177, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "GREEN";
            // 
            // graphYellow2
            // 
            this.graphYellow2.Location = new System.Drawing.Point(807, 19);
            this.graphYellow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphYellow2.Name = "graphYellow2";
            this.graphYellow2.ScrollGrace = 0D;
            this.graphYellow2.ScrollMaxX = 0D;
            this.graphYellow2.ScrollMaxY = 0D;
            this.graphYellow2.ScrollMaxY2 = 0D;
            this.graphYellow2.ScrollMinX = 0D;
            this.graphYellow2.ScrollMinY = 0D;
            this.graphYellow2.ScrollMinY2 = 0D;
            this.graphYellow2.Size = new System.Drawing.Size(125, 150);
            this.graphYellow2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(50, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "RED";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(708, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "YELLOW1";
            // 
            // graphAmb0
            // 
            this.graphAmb0.Location = new System.Drawing.Point(399, 19);
            this.graphAmb0.Name = "graphAmb0";
            this.graphAmb0.ScrollGrace = 0D;
            this.graphAmb0.ScrollMaxX = 0D;
            this.graphAmb0.ScrollMaxY = 0D;
            this.graphAmb0.ScrollMaxY2 = 0D;
            this.graphAmb0.ScrollMinX = 0D;
            this.graphAmb0.ScrollMinY = 0D;
            this.graphAmb0.ScrollMinY2 = 0D;
            this.graphAmb0.Size = new System.Drawing.Size(125, 150);
            this.graphAmb0.TabIndex = 7;
            // 
            // graphYellow1
            // 
            this.graphYellow1.Location = new System.Drawing.Point(676, 19);
            this.graphYellow1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphYellow1.Name = "graphYellow1";
            this.graphYellow1.ScrollGrace = 0D;
            this.graphYellow1.ScrollMaxX = 0D;
            this.graphYellow1.ScrollMaxY = 0D;
            this.graphYellow1.ScrollMaxY2 = 0D;
            this.graphYellow1.ScrollMinX = 0D;
            this.graphYellow1.ScrollMinY = 0D;
            this.graphYellow1.ScrollMinY2 = 0D;
            this.graphYellow1.Size = new System.Drawing.Size(125, 150);
            this.graphYellow1.TabIndex = 5;
            // 
            // graphBlue
            // 
            this.graphBlue.Location = new System.Drawing.Point(268, 19);
            this.graphBlue.Name = "graphBlue";
            this.graphBlue.ScrollGrace = 0D;
            this.graphBlue.ScrollMaxX = 0D;
            this.graphBlue.ScrollMaxY = 0D;
            this.graphBlue.ScrollMaxY2 = 0D;
            this.graphBlue.ScrollMinX = 0D;
            this.graphBlue.ScrollMinY = 0D;
            this.graphBlue.ScrollMinY2 = 0D;
            this.graphBlue.Size = new System.Drawing.Size(125, 150);
            this.graphBlue.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(602, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "IR";
            // 
            // graphGreen
            // 
            this.graphGreen.Location = new System.Drawing.Point(137, 19);
            this.graphGreen.Name = "graphGreen";
            this.graphGreen.ScrollGrace = 0D;
            this.graphGreen.ScrollMaxX = 0D;
            this.graphGreen.ScrollMaxY = 0D;
            this.graphGreen.ScrollMaxY2 = 0D;
            this.graphGreen.ScrollMinX = 0D;
            this.graphGreen.ScrollMinY = 0D;
            this.graphGreen.ScrollMinY2 = 0D;
            this.graphGreen.Size = new System.Drawing.Size(125, 150);
            this.graphGreen.TabIndex = 5;
            // 
            // graphIr
            // 
            this.graphIr.Location = new System.Drawing.Point(545, 19);
            this.graphIr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphIr.Name = "graphIr";
            this.graphIr.ScrollGrace = 0D;
            this.graphIr.ScrollMaxX = 0D;
            this.graphIr.ScrollMaxY = 0D;
            this.graphIr.ScrollMaxY2 = 0D;
            this.graphIr.ScrollMinX = 0D;
            this.graphIr.ScrollMinY = 0D;
            this.graphIr.ScrollMinY2 = 0D;
            this.graphIr.Size = new System.Drawing.Size(125, 150);
            this.graphIr.TabIndex = 4;
            // 
            // graphRed
            // 
            this.graphRed.Location = new System.Drawing.Point(6, 19);
            this.graphRed.Name = "graphRed";
            this.graphRed.ScrollGrace = 0D;
            this.graphRed.ScrollMaxX = 0D;
            this.graphRed.ScrollMaxY = 0D;
            this.graphRed.ScrollMaxY2 = 0D;
            this.graphRed.ScrollMinX = 0D;
            this.graphRed.ScrollMinY = 0D;
            this.graphRed.ScrollMinY2 = 0D;
            this.graphRed.Size = new System.Drawing.Size(125, 150);
            this.graphRed.TabIndex = 4;
            // 
            // gbPressure1
            // 
            this.gbPressure1.Controls.Add(this.label21);
            this.gbPressure1.Controls.Add(this.label22);
            this.gbPressure1.Controls.Add(this.label17);
            this.gbPressure1.Controls.Add(this.label23);
            this.gbPressure1.Controls.Add(this.label18);
            this.gbPressure1.Controls.Add(this.label24);
            this.gbPressure1.Controls.Add(this.graphBn1Ch8);
            this.gbPressure1.Controls.Add(this.graphBn1Ch4);
            this.gbPressure1.Controls.Add(this.label19);
            this.gbPressure1.Controls.Add(this.graphBn1Ch7);
            this.gbPressure1.Controls.Add(this.graphBn1Ch3);
            this.gbPressure1.Controls.Add(this.label20);
            this.gbPressure1.Controls.Add(this.graphBn1Ch6);
            this.gbPressure1.Controls.Add(this.graphBn1Ch2);
            this.gbPressure1.Controls.Add(this.graphBn1Ch5);
            this.gbPressure1.Controls.Add(this.graphBn1Ch1);
            this.gbPressure1.Font = new System.Drawing.Font("Arial", 9F);
            this.gbPressure1.Location = new System.Drawing.Point(12, 418);
            this.gbPressure1.Name = "gbPressure1";
            this.gbPressure1.Size = new System.Drawing.Size(1072, 197);
            this.gbPressure1.TabIndex = 9;
            this.gbPressure1.TabStop = false;
            this.gbPressure1.Text = "Pressure Band1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 10F);
            this.label21.Location = new System.Drawing.Point(988, 172);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 16);
            this.label21.TabIndex = 18;
            this.label21.Text = "CH8";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 10F);
            this.label22.Location = new System.Drawing.Point(858, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 16);
            this.label22.TabIndex = 17;
            this.label22.Text = "CH7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10F);
            this.label17.Location = new System.Drawing.Point(448, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 16);
            this.label17.TabIndex = 14;
            this.label17.Text = "CH4";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 10F);
            this.label23.Location = new System.Drawing.Point(728, 172);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 16);
            this.label23.TabIndex = 16;
            this.label23.Text = "CH6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 10F);
            this.label18.Location = new System.Drawing.Point(318, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 16);
            this.label18.TabIndex = 13;
            this.label18.Text = "CH3";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 10F);
            this.label24.Location = new System.Drawing.Point(595, 172);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 16);
            this.label24.TabIndex = 15;
            this.label24.Text = "CH5";
            // 
            // graphBn1Ch8
            // 
            this.graphBn1Ch8.Location = new System.Drawing.Point(938, 19);
            this.graphBn1Ch8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBn1Ch8.Name = "graphBn1Ch8";
            this.graphBn1Ch8.ScrollGrace = 0D;
            this.graphBn1Ch8.ScrollMaxX = 0D;
            this.graphBn1Ch8.ScrollMaxY = 0D;
            this.graphBn1Ch8.ScrollMaxY2 = 0D;
            this.graphBn1Ch8.ScrollMinX = 0D;
            this.graphBn1Ch8.ScrollMinY = 0D;
            this.graphBn1Ch8.ScrollMinY2 = 0D;
            this.graphBn1Ch8.Size = new System.Drawing.Size(125, 150);
            this.graphBn1Ch8.TabIndex = 7;
            // 
            // graphBn1Ch4
            // 
            this.graphBn1Ch4.Location = new System.Drawing.Point(399, 19);
            this.graphBn1Ch4.Name = "graphBn1Ch4";
            this.graphBn1Ch4.ScrollGrace = 0D;
            this.graphBn1Ch4.ScrollMaxX = 0D;
            this.graphBn1Ch4.ScrollMaxY = 0D;
            this.graphBn1Ch4.ScrollMaxY2 = 0D;
            this.graphBn1Ch4.ScrollMinX = 0D;
            this.graphBn1Ch4.ScrollMinY = 0D;
            this.graphBn1Ch4.ScrollMinY2 = 0D;
            this.graphBn1Ch4.Size = new System.Drawing.Size(125, 150);
            this.graphBn1Ch4.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 10F);
            this.label19.Location = new System.Drawing.Point(188, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "CH2";
            // 
            // graphBn1Ch7
            // 
            this.graphBn1Ch7.Location = new System.Drawing.Point(807, 19);
            this.graphBn1Ch7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBn1Ch7.Name = "graphBn1Ch7";
            this.graphBn1Ch7.ScrollGrace = 0D;
            this.graphBn1Ch7.ScrollMaxX = 0D;
            this.graphBn1Ch7.ScrollMaxY = 0D;
            this.graphBn1Ch7.ScrollMaxY2 = 0D;
            this.graphBn1Ch7.ScrollMinX = 0D;
            this.graphBn1Ch7.ScrollMinY = 0D;
            this.graphBn1Ch7.ScrollMinY2 = 0D;
            this.graphBn1Ch7.Size = new System.Drawing.Size(125, 150);
            this.graphBn1Ch7.TabIndex = 6;
            // 
            // graphBn1Ch3
            // 
            this.graphBn1Ch3.Location = new System.Drawing.Point(268, 19);
            this.graphBn1Ch3.Name = "graphBn1Ch3";
            this.graphBn1Ch3.ScrollGrace = 0D;
            this.graphBn1Ch3.ScrollMaxX = 0D;
            this.graphBn1Ch3.ScrollMaxY = 0D;
            this.graphBn1Ch3.ScrollMaxY2 = 0D;
            this.graphBn1Ch3.ScrollMinX = 0D;
            this.graphBn1Ch3.ScrollMinY = 0D;
            this.graphBn1Ch3.ScrollMinY2 = 0D;
            this.graphBn1Ch3.Size = new System.Drawing.Size(125, 150);
            this.graphBn1Ch3.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 10F);
            this.label20.Location = new System.Drawing.Point(55, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "CH1";
            // 
            // graphBn1Ch6
            // 
            this.graphBn1Ch6.Location = new System.Drawing.Point(676, 19);
            this.graphBn1Ch6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBn1Ch6.Name = "graphBn1Ch6";
            this.graphBn1Ch6.ScrollGrace = 0D;
            this.graphBn1Ch6.ScrollMaxX = 0D;
            this.graphBn1Ch6.ScrollMaxY = 0D;
            this.graphBn1Ch6.ScrollMaxY2 = 0D;
            this.graphBn1Ch6.ScrollMinX = 0D;
            this.graphBn1Ch6.ScrollMinY = 0D;
            this.graphBn1Ch6.ScrollMinY2 = 0D;
            this.graphBn1Ch6.Size = new System.Drawing.Size(125, 150);
            this.graphBn1Ch6.TabIndex = 5;
            // 
            // graphBn1Ch2
            // 
            this.graphBn1Ch2.Location = new System.Drawing.Point(137, 19);
            this.graphBn1Ch2.Name = "graphBn1Ch2";
            this.graphBn1Ch2.ScrollGrace = 0D;
            this.graphBn1Ch2.ScrollMaxX = 0D;
            this.graphBn1Ch2.ScrollMaxY = 0D;
            this.graphBn1Ch2.ScrollMaxY2 = 0D;
            this.graphBn1Ch2.ScrollMinX = 0D;
            this.graphBn1Ch2.ScrollMinY = 0D;
            this.graphBn1Ch2.ScrollMinY2 = 0D;
            this.graphBn1Ch2.Size = new System.Drawing.Size(125, 150);
            this.graphBn1Ch2.TabIndex = 5;
            // 
            // graphBn1Ch5
            // 
            this.graphBn1Ch5.Location = new System.Drawing.Point(545, 19);
            this.graphBn1Ch5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBn1Ch5.Name = "graphBn1Ch5";
            this.graphBn1Ch5.ScrollGrace = 0D;
            this.graphBn1Ch5.ScrollMaxX = 0D;
            this.graphBn1Ch5.ScrollMaxY = 0D;
            this.graphBn1Ch5.ScrollMaxY2 = 0D;
            this.graphBn1Ch5.ScrollMinX = 0D;
            this.graphBn1Ch5.ScrollMinY = 0D;
            this.graphBn1Ch5.ScrollMinY2 = 0D;
            this.graphBn1Ch5.Size = new System.Drawing.Size(125, 150);
            this.graphBn1Ch5.TabIndex = 4;
            // 
            // graphBn1Ch1
            // 
            this.graphBn1Ch1.Location = new System.Drawing.Point(6, 19);
            this.graphBn1Ch1.Name = "graphBn1Ch1";
            this.graphBn1Ch1.ScrollGrace = 0D;
            this.graphBn1Ch1.ScrollMaxX = 0D;
            this.graphBn1Ch1.ScrollMaxY = 0D;
            this.graphBn1Ch1.ScrollMaxY2 = 0D;
            this.graphBn1Ch1.ScrollMinX = 0D;
            this.graphBn1Ch1.ScrollMinY = 0D;
            this.graphBn1Ch1.ScrollMinY2 = 0D;
            this.graphBn1Ch1.Size = new System.Drawing.Size(125, 150);
            this.graphBn1Ch1.TabIndex = 4;
            // 
            // gbPressure2
            // 
            this.gbPressure2.Controls.Add(this.label29);
            this.gbPressure2.Controls.Add(this.label25);
            this.gbPressure2.Controls.Add(this.label30);
            this.gbPressure2.Controls.Add(this.graphBn2Ch4);
            this.gbPressure2.Controls.Add(this.label26);
            this.gbPressure2.Controls.Add(this.graphBn2Ch8);
            this.gbPressure2.Controls.Add(this.label27);
            this.gbPressure2.Controls.Add(this.label31);
            this.gbPressure2.Controls.Add(this.graphBn2Ch3);
            this.gbPressure2.Controls.Add(this.label28);
            this.gbPressure2.Controls.Add(this.graphBn2Ch7);
            this.gbPressure2.Controls.Add(this.graphBn2Ch2);
            this.gbPressure2.Controls.Add(this.graphBn2Ch1);
            this.gbPressure2.Controls.Add(this.label32);
            this.gbPressure2.Controls.Add(this.graphBn2Ch5);
            this.gbPressure2.Controls.Add(this.graphBn2Ch6);
            this.gbPressure2.Font = new System.Drawing.Font("Arial", 9F);
            this.gbPressure2.Location = new System.Drawing.Point(12, 621);
            this.gbPressure2.Name = "gbPressure2";
            this.gbPressure2.Size = new System.Drawing.Size(1072, 197);
            this.gbPressure2.TabIndex = 10;
            this.gbPressure2.TabStop = false;
            this.gbPressure2.Text = "Pressure Band2";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 10F);
            this.label29.Location = new System.Drawing.Point(988, 172);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 16);
            this.label29.TabIndex = 22;
            this.label29.Text = "CH8";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 10F);
            this.label25.Location = new System.Drawing.Point(449, 172);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 16);
            this.label25.TabIndex = 18;
            this.label25.Text = "CH4";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 10F);
            this.label30.Location = new System.Drawing.Point(858, 172);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 16);
            this.label30.TabIndex = 21;
            this.label30.Text = "CH7";
            // 
            // graphBn2Ch4
            // 
            this.graphBn2Ch4.Location = new System.Drawing.Point(399, 19);
            this.graphBn2Ch4.Name = "graphBn2Ch4";
            this.graphBn2Ch4.ScrollGrace = 0D;
            this.graphBn2Ch4.ScrollMaxX = 0D;
            this.graphBn2Ch4.ScrollMaxY = 0D;
            this.graphBn2Ch4.ScrollMaxY2 = 0D;
            this.graphBn2Ch4.ScrollMinX = 0D;
            this.graphBn2Ch4.ScrollMinY = 0D;
            this.graphBn2Ch4.ScrollMinY2 = 0D;
            this.graphBn2Ch4.Size = new System.Drawing.Size(125, 150);
            this.graphBn2Ch4.TabIndex = 7;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 10F);
            this.label26.Location = new System.Drawing.Point(319, 172);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 16);
            this.label26.TabIndex = 17;
            this.label26.Text = "CH3";
            // 
            // graphBn2Ch8
            // 
            this.graphBn2Ch8.Location = new System.Drawing.Point(938, 19);
            this.graphBn2Ch8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBn2Ch8.Name = "graphBn2Ch8";
            this.graphBn2Ch8.ScrollGrace = 0D;
            this.graphBn2Ch8.ScrollMaxX = 0D;
            this.graphBn2Ch8.ScrollMaxY = 0D;
            this.graphBn2Ch8.ScrollMaxY2 = 0D;
            this.graphBn2Ch8.ScrollMinX = 0D;
            this.graphBn2Ch8.ScrollMinY = 0D;
            this.graphBn2Ch8.ScrollMinY2 = 0D;
            this.graphBn2Ch8.Size = new System.Drawing.Size(125, 150);
            this.graphBn2Ch8.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 10F);
            this.label27.Location = new System.Drawing.Point(189, 172);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 16);
            this.label27.TabIndex = 16;
            this.label27.Text = "CH2";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 10F);
            this.label31.Location = new System.Drawing.Point(728, 172);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 16);
            this.label31.TabIndex = 20;
            this.label31.Text = "CH6";
            // 
            // graphBn2Ch3
            // 
            this.graphBn2Ch3.Location = new System.Drawing.Point(268, 19);
            this.graphBn2Ch3.Name = "graphBn2Ch3";
            this.graphBn2Ch3.ScrollGrace = 0D;
            this.graphBn2Ch3.ScrollMaxX = 0D;
            this.graphBn2Ch3.ScrollMaxY = 0D;
            this.graphBn2Ch3.ScrollMaxY2 = 0D;
            this.graphBn2Ch3.ScrollMinX = 0D;
            this.graphBn2Ch3.ScrollMinY = 0D;
            this.graphBn2Ch3.ScrollMinY2 = 0D;
            this.graphBn2Ch3.Size = new System.Drawing.Size(125, 150);
            this.graphBn2Ch3.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 10F);
            this.label28.Location = new System.Drawing.Point(56, 172);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 16);
            this.label28.TabIndex = 15;
            this.label28.Text = "CH1";
            // 
            // graphBn2Ch7
            // 
            this.graphBn2Ch7.Location = new System.Drawing.Point(807, 19);
            this.graphBn2Ch7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBn2Ch7.Name = "graphBn2Ch7";
            this.graphBn2Ch7.ScrollGrace = 0D;
            this.graphBn2Ch7.ScrollMaxX = 0D;
            this.graphBn2Ch7.ScrollMaxY = 0D;
            this.graphBn2Ch7.ScrollMaxY2 = 0D;
            this.graphBn2Ch7.ScrollMinX = 0D;
            this.graphBn2Ch7.ScrollMinY = 0D;
            this.graphBn2Ch7.ScrollMinY2 = 0D;
            this.graphBn2Ch7.Size = new System.Drawing.Size(125, 150);
            this.graphBn2Ch7.TabIndex = 6;
            // 
            // graphBn2Ch2
            // 
            this.graphBn2Ch2.Location = new System.Drawing.Point(137, 19);
            this.graphBn2Ch2.Name = "graphBn2Ch2";
            this.graphBn2Ch2.ScrollGrace = 0D;
            this.graphBn2Ch2.ScrollMaxX = 0D;
            this.graphBn2Ch2.ScrollMaxY = 0D;
            this.graphBn2Ch2.ScrollMaxY2 = 0D;
            this.graphBn2Ch2.ScrollMinX = 0D;
            this.graphBn2Ch2.ScrollMinY = 0D;
            this.graphBn2Ch2.ScrollMinY2 = 0D;
            this.graphBn2Ch2.Size = new System.Drawing.Size(125, 150);
            this.graphBn2Ch2.TabIndex = 5;
            // 
            // graphBn2Ch1
            // 
            this.graphBn2Ch1.Location = new System.Drawing.Point(6, 19);
            this.graphBn2Ch1.Name = "graphBn2Ch1";
            this.graphBn2Ch1.ScrollGrace = 0D;
            this.graphBn2Ch1.ScrollMaxX = 0D;
            this.graphBn2Ch1.ScrollMaxY = 0D;
            this.graphBn2Ch1.ScrollMaxY2 = 0D;
            this.graphBn2Ch1.ScrollMinX = 0D;
            this.graphBn2Ch1.ScrollMinY = 0D;
            this.graphBn2Ch1.ScrollMinY2 = 0D;
            this.graphBn2Ch1.Size = new System.Drawing.Size(125, 150);
            this.graphBn2Ch1.TabIndex = 4;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 10F);
            this.label32.Location = new System.Drawing.Point(595, 172);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(35, 16);
            this.label32.TabIndex = 19;
            this.label32.Text = "CH5";
            // 
            // graphBn2Ch5
            // 
            this.graphBn2Ch5.Location = new System.Drawing.Point(545, 19);
            this.graphBn2Ch5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBn2Ch5.Name = "graphBn2Ch5";
            this.graphBn2Ch5.ScrollGrace = 0D;
            this.graphBn2Ch5.ScrollMaxX = 0D;
            this.graphBn2Ch5.ScrollMaxY = 0D;
            this.graphBn2Ch5.ScrollMaxY2 = 0D;
            this.graphBn2Ch5.ScrollMinX = 0D;
            this.graphBn2Ch5.ScrollMinY = 0D;
            this.graphBn2Ch5.ScrollMinY2 = 0D;
            this.graphBn2Ch5.Size = new System.Drawing.Size(125, 150);
            this.graphBn2Ch5.TabIndex = 4;
            // 
            // graphBn2Ch6
            // 
            this.graphBn2Ch6.Location = new System.Drawing.Point(676, 19);
            this.graphBn2Ch6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphBn2Ch6.Name = "graphBn2Ch6";
            this.graphBn2Ch6.ScrollGrace = 0D;
            this.graphBn2Ch6.ScrollMaxX = 0D;
            this.graphBn2Ch6.ScrollMaxY = 0D;
            this.graphBn2Ch6.ScrollMaxY2 = 0D;
            this.graphBn2Ch6.ScrollMinX = 0D;
            this.graphBn2Ch6.ScrollMinY = 0D;
            this.graphBn2Ch6.ScrollMinY2 = 0D;
            this.graphBn2Ch6.Size = new System.Drawing.Size(125, 150);
            this.graphBn2Ch6.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 830);
            this.Controls.Add(this.gbPressure2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbPressure1);
            this.Controls.Add(this.gbGyro);
            this.Controls.Add(this.gbPpg);
            this.Controls.Add(this.gbAcc);
            this.Controls.Add(this.gbSettings);
            this.Name = "Form1";
            this.Text = "CBP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbAcc.ResumeLayout(false);
            this.gbAcc.PerformLayout();
            this.gbGyro.ResumeLayout(false);
            this.gbGyro.PerformLayout();
            this.gbPpg.ResumeLayout(false);
            this.gbPpg.PerformLayout();
            this.gbPressure1.ResumeLayout(false);
            this.gbPressure1.PerformLayout();
            this.gbPressure2.ResumeLayout(false);
            this.gbPressure2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Button btnConnect;
        private ZedGraph.ZedGraphControl graphAccX;
        private System.Windows.Forms.GroupBox gbAcc;
        private System.Windows.Forms.GroupBox gbPpg;
        private ZedGraph.ZedGraphControl graphAmb0;
        private ZedGraph.ZedGraphControl graphBlue;
        private ZedGraph.ZedGraphControl graphGreen;
        private ZedGraph.ZedGraphControl graphRed;
        private ZedGraph.ZedGraphControl graphAmb1;
        private ZedGraph.ZedGraphControl graphYellow2;
        private ZedGraph.ZedGraphControl graphYellow1;
        private ZedGraph.ZedGraphControl graphIr;
        private ZedGraph.ZedGraphControl graphAccZ;
        private ZedGraph.ZedGraphControl graphAccY;
        private System.Windows.Forms.GroupBox gbGyro;
        private ZedGraph.ZedGraphControl graphGyroZ;
        private ZedGraph.ZedGraphControl graphGyroY;
        private ZedGraph.ZedGraphControl graphGyroX;
        private System.Windows.Forms.GroupBox gbPressure1;
        private ZedGraph.ZedGraphControl graphBn1Ch4;
        private ZedGraph.ZedGraphControl graphBn1Ch3;
        private ZedGraph.ZedGraphControl graphBn1Ch2;
        private ZedGraph.ZedGraphControl graphBn1Ch1;
        private System.Windows.Forms.GroupBox gbPressure2;
        private ZedGraph.ZedGraphControl graphBn2Ch4;
        private ZedGraph.ZedGraphControl graphBn2Ch3;
        private ZedGraph.ZedGraphControl graphBn2Ch2;
        private ZedGraph.ZedGraphControl graphBn2Ch1;
        private ZedGraph.ZedGraphControl graphBn1Ch8;
        private ZedGraph.ZedGraphControl graphBn1Ch7;
        private ZedGraph.ZedGraphControl graphBn1Ch6;
        private ZedGraph.ZedGraphControl graphBn1Ch5;
        private ZedGraph.ZedGraphControl graphBn2Ch8;
        private ZedGraph.ZedGraphControl graphBn2Ch7;
        private ZedGraph.ZedGraphControl graphBn2Ch6;
        private ZedGraph.ZedGraphControl graphBn2Ch5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}

