using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.Power_Devices
{
    public class VoltageProbeRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_VoltageProbe")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, PowerDevicesConfig.VoltageProbeEventPropertyTypes));
            }
        }
    }
}
