using System;

namespace appLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            bool exit = false;
            Starter starter = new Starter();

            while (!exit)
            {
                Console.Clear();
                starter.Run();
                Logsys.Logger.ShowLog();
                Console.Write("\nPress <N> for next actions, <S> for save log to file and exit, <Q> to quit vithout saving.");
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.N:
                        break;

                    case ConsoleKey.S:
                        Logsys.Logger.SaveToFile();
                        exit = true;
                        break;

                    case ConsoleKey.Q:
                        exit = true;
                        break;
                }
            }
        }
    }
}
