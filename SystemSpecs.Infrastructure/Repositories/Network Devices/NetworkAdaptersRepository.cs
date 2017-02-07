using System.Management;
using SystemSpecs.Core.Hardware;

namespace SystemSpecs.Infrastructure.Repositories.NetworkDevices
{
    public sealed class NetworkAdaptersRepository : BaseRepository<NetworkAdapter>
    {
        private static NetworkAdaptersRepository _Instance;

        public static NetworkAdaptersRepository Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NetworkAdaptersRepository();
                }

                return _Instance;
            }
        }

        private NetworkAdaptersRepository() { }

        protected override void InitializeEntities()
        {
            var adapterEnumerator = new ManagementObjectSearcher(new SelectQuery("Win32_NetworkAdapter")).Get().GetEnumerator();
            var configurationEnumerator = new ManagementObjectSearcher(new SelectQuery("Win32_NetworkAdapterConfiguration")).Get().GetEnumerator();

            while(adapterEnumerator.MoveNext() && configurationEnumerator.MoveNext())
            {
                _EntityList.Add(new NetworkAdapter(adapterEnumerator.Current, configurationEnumerator.Current));
            }
        }
    }
}