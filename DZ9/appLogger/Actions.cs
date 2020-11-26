using System;

namespace appLogger
{
    public class Actions
    {
        public void GenerateInfo()
        {
            Logsys.Logger.addEvent(SeverityLevel.Info, "Start method: GenerateInfo");
        }

        public void GenerateWarning()
        {
            Logsys.Logger.addEvent(SeverityLevel.Warning, "Start method: GenerateWarning");
        }
        public void GenerateError()
        {
            throw new Exception("I broke a toilet");
        }
    }
}
