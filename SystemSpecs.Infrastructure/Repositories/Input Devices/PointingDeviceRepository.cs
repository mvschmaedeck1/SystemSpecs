using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.InputDevices
{
    public class PointingDeviceRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_PointingDevice")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, InputDevicesConfig.PointingDevicePropertyTypes));
            }
        }
    }
}