using System.Management;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Repository
{
    public class HeatPipeRepository : BaseRepository<HeatPipe>
    {
        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_HeatPipe")).Get())
            {
                _EntityList.Add(new HeatPipe(obj));
            }
        }
    }
}