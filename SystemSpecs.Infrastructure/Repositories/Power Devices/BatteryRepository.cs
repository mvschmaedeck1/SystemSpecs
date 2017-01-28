using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.PowerDevices
{
    public class BatteryRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Battery")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, PowerDevicesConfig.BatteryPropertyTypes));
            }
        }
    }
}
