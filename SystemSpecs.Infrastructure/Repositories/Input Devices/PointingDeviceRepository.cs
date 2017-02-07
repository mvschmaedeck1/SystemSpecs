using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.InputDevices
{
    public sealed class PointingDeviceRepository : BaseRepository<GenericHardware>
    {
        private static PointingDeviceRepository _Instance;

        public static PointingDeviceRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PointingDeviceRepository();
                }

                return _Instance;
            }
        }

        private PointingDeviceRepository() { }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_PointingDevice")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, InputDevicesConfig.PointingDevicePropertyTypes));
            }
        }
    }
}