using System.Management;
using SystemSpecs.Core.Hardware.InputDevices;

namespace SystemSpecs.Infrastructure.Repositories.InputDevices
{
    public class PointingDeviceRepository : BaseRepository<PointingDevice>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_PointingDevice")).Get())
            {
                _EntityList.Add(new PointingDevice(obj));
            }
        }
    }
}