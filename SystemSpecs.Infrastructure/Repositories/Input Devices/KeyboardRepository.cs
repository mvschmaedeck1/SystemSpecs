using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.InputDevices
{
    public sealed class KeyboardRepository : BaseRepository<GenericHardware>
    {
        private static KeyboardRepository _Instance;

        public static KeyboardRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KeyboardRepository();
                }

                return _Instance;
            }
        }

        private KeyboardRepository() { }

        protected override void InitializeEntities()
        {
            foreach(var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Keyboard")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, InputDevicesConfig.KeyboardPropertyTypes));
            }
        }
    }
}