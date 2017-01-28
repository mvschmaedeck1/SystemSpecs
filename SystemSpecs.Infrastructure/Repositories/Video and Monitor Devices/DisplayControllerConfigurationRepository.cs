using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.VideoAndMonitorDevices
{
    public class DisplayControllerConfigurationRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_DisplayControllerConfiguration")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, VideoAndMonitorConfig.DesktopMonitorPropertyTypes));
            }
        }
    }
}
