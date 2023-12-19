using System;

using pyRevitLabs.NLog;
using pyRevitLabs.NLog.Targets;

class Example
{
    static void Main(string[] args)
    {
        DebuggerTarget target = new DebuggerTarget();
        target.Layout = "${message}";

        NLog.Config.SimpleConfigurator.ConfigureForTargetLogging(target, LogLevel.Debug);

        Logger logger = LogManager.GetLogger("Example");
        logger.Debug("log message");
    }
}
