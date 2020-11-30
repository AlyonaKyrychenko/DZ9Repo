using System;
using System.IO;

namespace AppLogger
{

    public sealed class Logsys
    {
        private Logsys() { }

        private static Logsys Instance = null;
        public static Logsys Logger
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Logsys();
                }

                return Instance;
            }
        }

        private string[] log = new string[0];

        public void AddEvent(LoggerEnum.SeverityLevel severity, string text, bool needTrace)
        {
            int size = this.log.Length;
            Array.Resize(ref this.log, size + 1);
            if (needTrace)
            {
                this.log[size] = $"{{{severity.ToString()}}}:{{{text}}}\n{Environment.StackTrace}";
            }
            else {
                this.log[size] = $"{{{severity.ToString()}}}:{{{text}}})";
            }
        }
        public void ShowLog()
        {
            foreach (string logRecord in this.log)
            {
                Console.WriteLine(logRecord);
            }
            Console.WriteLine($"Count records in log {this.log.Length.ToString()}");
        }
        public void SaveToFile()
        {
            //Лог лежит DZ9\bin\Debug\netcoreapp3.1\myLog.dat
            StreamWriter str = new StreamWriter("myLog.dat");

            foreach (string logStr in this.log)
            {
                str.WriteLine(logStr);
            }
            str.Close();
        }
    }

}
