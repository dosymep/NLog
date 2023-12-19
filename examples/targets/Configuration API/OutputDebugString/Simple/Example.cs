using System;

using pyRevitLabs.NLog;
using pyRevitLabs.NLog.Targets;
using pyRevitLabs.NLog.Win32.Targets;

class Example
{
    static void Main(string[] args)
    {
        OutputDebugStringTarget target = new OutputDebugStringTarget();
        target.Layout = "${message}";

        NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(target, LogLevel.Debug);

        Logger logger = LogManager.GetLogger("Example");
        logger.Debug("log message");
    }
}
