using System;
using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.PowerDevices
{
    public sealed class PortableBatteryRepository : BaseRepository<GenericHardware>
    {
        private static PortableBatteryRepository _Instance;

        public static PortableBatteryRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PortableBatteryRepository();
                }

                return _Instance;
            }
        }

        private PortableBatteryRepository()
        {
            
        }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_PortableBattery")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, PowerDevicesConfig.PortableBatteryPropertyTypes));
            }
        }

        protected override void InitializaDisplayedProperties()
        {
            throw new NotImplementedException();
        }
    }
}
