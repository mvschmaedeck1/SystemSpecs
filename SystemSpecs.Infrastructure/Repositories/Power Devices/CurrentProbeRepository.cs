using System;
using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.PowerDevices
{
    public sealed class CurrentProbeRepository : BaseRepository<GenericHardware>
    {
        private static CurrentProbeRepository _Instance;

        public static CurrentProbeRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CurrentProbeRepository();
                }

                return _Instance;
            }
        }

        private CurrentProbeRepository()
        {
            LoadUserDisplayedProperties(GetType().Name);
        }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_CurrentProbe")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, PowerDevicesConfig.CurrentProbePropertyTypes));
            }
        }

        protected override void InitializaDisplayedProperties()
        {
            throw new NotImplementedException();
        }
    }
}