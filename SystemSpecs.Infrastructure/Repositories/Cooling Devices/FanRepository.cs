using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    public class FanRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Fan")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, InputDevicesConfig.KeyboardPropertyTypes));
            }
        }
    }
}