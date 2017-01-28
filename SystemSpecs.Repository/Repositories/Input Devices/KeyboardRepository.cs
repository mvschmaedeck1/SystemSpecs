using System.Management;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.InputDevices
{
    public class KeyboardRepository : BaseRepository<Keyboard>
    {
        protected override void InitializeEntities()
        {
            foreach(var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Keyboard")).Get())
            {
                _EntityList.Add(new Keyboard(obj));
            }
        }
    }
}