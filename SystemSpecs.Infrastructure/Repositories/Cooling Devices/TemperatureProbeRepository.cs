using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    class TemperatureProbeRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_TemperatureProbe")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, CoolingDevicesConfig.TemperatureProbePropertyTypes));
            }
        }
    }
}