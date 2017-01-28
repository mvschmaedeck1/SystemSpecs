using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.PowerDevices
{
    public class PortableBatteryRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_PortableBattery")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, PowerDevicesConfig.PortableBatteryPropertyTypes));
            }
        }
    }
}
