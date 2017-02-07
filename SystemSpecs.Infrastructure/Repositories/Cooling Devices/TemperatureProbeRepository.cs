using System;
using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    public sealed class TemperatureProbeRepository : BaseRepository<GenericHardware>
    {
        private static TemperatureProbeRepository _Instance;

        public static TemperatureProbeRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TemperatureProbeRepository();
                }

                return _Instance;
            }
        }

        private TemperatureProbeRepository()
        {
            
        }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_TemperatureProbe")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, CoolingDevicesConfig.TemperatureProbePropertyTypes));
            }
        }

        protected override void InitializaDisplayedProperties()
        {
            throw new NotImplementedException();
        }
    }
}