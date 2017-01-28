using System;
using System.Management;
using SystemSpecs.Core.Config;

namespace SystemSpecs.Core.Hardware.CoolingDevices
{
    public class HeatPipe : BaseHardware
    {
        private ManagementBaseObject _HeatPipeObject;

        public HeatPipe(ManagementBaseObject genericObject)
        {
            _HeatPipeObject = genericObject;
        }

        public override object GetProperty(string propertyName)
        {
            object value = _HeatPipeObject[propertyName];
            Type type;

            TryGetPropertyType(propertyName, CoolingDevicesConfig.HeatPipePropertyTypes, out type);

            return GetConvertedPropertyValue(value, type);
        }
    }
}
