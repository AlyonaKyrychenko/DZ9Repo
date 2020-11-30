using System;

namespace AppLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Starter starter = new Starter();

            while (!exit)
            {
                Console.Clear();
                starter.Run();
                Logsys.Logger.ShowLog();
                Console.ReadKey();
            }
        }
    }
}
