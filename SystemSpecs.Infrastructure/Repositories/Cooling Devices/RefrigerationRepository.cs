using System;
using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.CoolingDevices
{
    public sealed class RefrigerationRepository : BaseRepository<GenericHardware>
    {
        private static RefrigerationRepository _Instance;

        public static RefrigerationRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RefrigerationRepository();
                }

                return _Instance;
            }
        }

        private RefrigerationRepository()
        {
            
        }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_Refrigeration")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, CoolingDevicesConfig.RefrigerationPropertyTypes));
            }
        }

        protected override void InitializaDisplayedProperties()
        {
            throw new NotImplementedException();
        }
    }
}