using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    public class HeatPipeRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_HeatPipe")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, CoolingDevicesConfig.HeatPipePropertyTypes));
            }
        }
    }
}