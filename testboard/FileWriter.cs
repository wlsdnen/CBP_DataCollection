using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testboard
{
    class FileWriter
    {
        private const String FILE_FORMAT = ".dat";

        private String filename;
        private String dataname;
        private FileStream stream;
        private StreamWriter sWriter;

        public FileWriter(String time, String dataname)
        {
            this.filename = String.Join("_", time, dataname) + FILE_FORMAT;
            this.dataname = dataname;
            this.stream = null;
            this.sWriter = null;
        }

        // 한 줄씩 파일 쓰기
        public void WriteLine(int[] points)
        {
            if (stream == null && sWriter == null)
            {
                this.stream = new FileStream(this.filename, FileMode.Append);
                this.sWriter = new StreamWriter(this.stream);
            }

            try
            {
                string output = string.Join(",", points);
                sWriter.WriteLine(output);
                sWriter.Flush();
            }
            catch
            {
                Console.WriteLine("writing error");
            }

        }

        public void CloseWriter()
        {
            try
            {
                stream.Close();
                sWriter.Close();
            }
            catch
            {

            }
            
        }

    }
}
