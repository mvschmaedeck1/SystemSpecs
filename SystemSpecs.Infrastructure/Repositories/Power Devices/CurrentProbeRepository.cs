using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.PowerDevices
{
    public class CurrentProbeRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_CurrentProbe")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, PowerDevicesConfig.CurrentProbePropertyTypes));
            }
        }
    }
}