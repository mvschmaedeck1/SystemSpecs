using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.InputDevices
{
    public class KeyboardRepository : BaseRepository<GenericHardware>
    {
        protected override void InitializeEntities()
        {
            foreach(var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Keyboard")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, InputDevicesConfig.KeyboardPropertyTypes));
            }
        }
    }
}