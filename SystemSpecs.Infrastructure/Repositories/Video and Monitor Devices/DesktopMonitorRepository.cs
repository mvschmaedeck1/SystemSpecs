using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.VideoAndMonitorDevices
{
    public class DesktopMonitorRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_DesktopMonitor")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, VideoAndMonitorConfig.DesktopMonitorPropertyTypes));
            }
        }
    }
}
