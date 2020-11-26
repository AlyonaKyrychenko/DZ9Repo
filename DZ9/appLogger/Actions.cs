using System;

namespace AppLogger
{
    public class Actions
    {
        public void GenerateInfo()
        {
            Logsys.Logger.AddEvent(LoggerEnum.SeverityLevel.Info, "Start method: nameof(GenerateInfo)");
        }

        public void GenerateWarning()
        {
            Logsys.Logger.AddEvent(LoggerEnum.SeverityLevel.Warning, "Start method: nameof(GenerateWarning)");
        }

        public void GenerateError()
        {
            throw new Exception("I broke a toilet");
        }
    }
}
