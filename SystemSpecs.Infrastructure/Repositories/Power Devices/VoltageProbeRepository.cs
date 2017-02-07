using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.Power_Devices
{
    public sealed class VoltageProbeRepository : BaseRepository<GenericHardware>
    {
        private static VoltageProbeRepository _Instance;

        public static VoltageProbeRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new VoltageProbeRepository();
                }

                return _Instance;
            }
        }

        private VoltageProbeRepository() { }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_VoltageProbe")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, PowerDevicesConfig.VoltageProbeEventPropertyTypes));
            }
        }
    }
}
