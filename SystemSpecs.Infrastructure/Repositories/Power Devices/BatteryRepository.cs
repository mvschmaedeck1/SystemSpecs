using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.PowerDevices
{
    public sealed class BatteryRepository : BaseRepository<GenericHardware>
    {
        private static BatteryRepository _Instance;

        public static BatteryRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BatteryRepository();
                }

                return _Instance;
            }
        }

        private BatteryRepository() { }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Battery")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, PowerDevicesConfig.BatteryPropertyTypes));
            }
        }
    }
}
