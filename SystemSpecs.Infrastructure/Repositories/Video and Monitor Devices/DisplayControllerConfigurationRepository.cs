using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.VideoAndMonitorDevices
{
    public sealed class DisplayControllerConfigurationRepository : BaseRepository<GenericHardware>
    {
        private static DisplayControllerConfigurationRepository _Instance;

        public static DisplayControllerConfigurationRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DisplayControllerConfigurationRepository();
                }

                return _Instance;
            }
        }

        private DisplayControllerConfigurationRepository() { }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_DisplayControllerConfiguration")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, VideoAndMonitorConfig.DesktopMonitorPropertyTypes));
            }
        }
    }
}
