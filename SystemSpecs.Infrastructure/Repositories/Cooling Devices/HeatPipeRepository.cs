using System;
using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    public sealed class HeatPipeRepository : BaseRepository<GenericHardware>
    {
        private static HeatPipeRepository _Instance;

        public static HeatPipeRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HeatPipeRepository();
                }

                return _Instance;
            }
        }

        private HeatPipeRepository()
        {
            LoadUserDisplayedProperties(GetType().Name);
        }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_HeatPipe")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, CoolingDevicesConfig.HeatPipePropertyTypes));
            }
        }

        protected override void InitializaDisplayedProperties()
        {
            throw new NotImplementedException();
        }
    }
}