using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.VideoAndMonitorDevices
{
    public sealed class DesktopMonitorRepository : BaseRepository<GenericHardware>
    {
        private static DesktopMonitorRepository _Instance;

        public static DesktopMonitorRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DesktopMonitorRepository();
                }

                return _Instance;
            }
        }

        private DesktopMonitorRepository() { }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_DesktopMonitor")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, VideoAndMonitorConfig.DesktopMonitorPropertyTypes));
            }
        }
    }
}
