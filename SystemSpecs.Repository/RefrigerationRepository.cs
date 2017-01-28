using System.Management;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Repository
{
    public class RefrigerationRepository : BaseRepository<Refrigeration>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Refrigeration")).Get())
            {
                _EntityList.Add(new Refrigeration(obj));
            }
        }
    }
}