using System;

namespace AppLogger
{
    public class Starter
    {
        public void Run()
        {
            Actions action = new Actions();
            Random rnd = new Random();
            rnd.Next(1, 3);

            for (int i = 0; i < 100; i++)
            {
                int act = rnd.Next(1, 4);

                switch (act)
                {

                    case 1:
                        action.GenerateInfo();
                        Logsys.Logger.SaveToFile();
                        break;

                    case 2:
                        action.GenerateWarning();
                        Logsys.Logger.SaveToFile();
                        break;

                    case 3:
                        try
                        {
                            action.GenerateError();
                            Logsys.Logger.SaveToFile();
                            break;
                        }
                        catch
                        {
                            Logsys.Logger.AddEvent(LoggerEnum.SeverityLevel.Error, "I broke a toilet");
                            Logsys.Logger.SaveToFile();
                        }
                        break;
                }
            }
        }
    }
}
