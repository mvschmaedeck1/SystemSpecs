using System;
using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    public sealed class FanRepository : BaseRepository<GenericHardware>
    {
        private static FanRepository _Instance;

        public static FanRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FanRepository();
                }

                return _Instance;
            }
        }

        private FanRepository()
        {
            
        }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Fan")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, InputDevicesConfig.KeyboardPropertyTypes));
            }
        }

        protected override void InitializaDisplayedProperties()
        {
            throw new NotImplementedException();
        }
    }
}