using System;
using System.Management;
using SystemSpecs.Core.Config;
using SystemSpecs.Core.Hardware;
using SystemSpecs.Infrastructure.Repositories;

namespace SystemSpecs.Repository.Repositories.VideoAndMonitorDevices
{
    public sealed class VideoControllerRepository : BaseRepository<GenericHardware>
    {
        private static VideoControllerRepository _Instance;

        public static VideoControllerRepository Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new VideoControllerRepository();
                }

                return _Instance;
            }
        }

        private VideoControllerRepository()
        {
            LoadUserDisplayedProperties(GetType().Name);
        }

        protected override void InitializeEntities()
        {
            foreach (var obj in new ManagementObjectSearcher(new SelectQuery("Win32_VideoController")).Get())
            {
                _EntityList.Add(new GenericHardware(obj, VideoAndMonitorConfig.DesktopMonitorPropertyTypes));
            }
        }

        protected override void InitializaDisplayedProperties()
        {
            throw new NotImplementedException();
        }
    }
}