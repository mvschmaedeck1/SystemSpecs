using System.Management;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    public class FanRepository : BaseRepository<FAN>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Fan")).Get())
            {
                _EntityList.Add(new FAN(obj));
            }
        }
    }
}