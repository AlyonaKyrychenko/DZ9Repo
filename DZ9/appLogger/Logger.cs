using System;
using System.IO;

namespace appLogger
{
    public enum SeverityLevel
    {
        Info,
        Warning,
        Error
    }

    public sealed class Logsys
    {
        private Logsys() { }

        private static Logsys loggerBody = null;
        public static Logsys Logger
        {
            get
            {
                if (loggerBody == null)
                {
                    loggerBody = new Logsys();
                }

                return loggerBody;
            }
        }

        private string[] log = new string[0];

        public void addEvent(SeverityLevel severity, string text)
        {
            int size = this.log.Length;
            Array.Resize(ref this.log, size + 1);
            this.log[size] = $"{{{severity.ToString()}}}:{{{text}}}";
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
