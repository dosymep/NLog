using pyRevitLabs.NLog;
using pyRevitLabs.NLog.Targets;

namespace ManuallyLoadedExtension
{
    [Target("ManuallyLoadedTarget")]
    public class ManuallyLoadedTarget : Target
    {
        protected override void Write(LogEventInfo logEvent)
        {
            // do nothing
        }
    }
}
