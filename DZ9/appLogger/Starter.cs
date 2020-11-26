using System;

namespace appLogger
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
                        break;

                    case 2:
                        action.GenerateWarning();
                        break;

                    case 3:
                        try
                        {
                            action.GenerateError();
                            break;
                        }
                        catch
                        {
                            Logsys.Logger.addEvent(SeverityLevel.Error, "I broke a toilet");
                        }
                        break;
                }
            }
        }
    }
}
