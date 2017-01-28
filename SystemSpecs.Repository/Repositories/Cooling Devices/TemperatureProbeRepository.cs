using System.Management;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    class TemperatureProbeRepository : BaseRepository<TemperatureProbe>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_TemperatureProbe")).Get())
            {
                _EntityList.Add(new TemperatureProbe(obj));
            }
        }
    }
}