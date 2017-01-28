using System;
using System.Management;
using SystemSpecs.Core.Config;

namespace SystemSpecs.Core.Hardware
{
    public class FAN : BaseHardware
    {
        private ManagementBaseObject _FanObject;

        public FAN(ManagementBaseObject genericObject)
        {
            _FanObject = genericObject;
        }

        public override object GetProperty(string propertyName)
        {
            object value = _FanObject[propertyName];
            Type type;

            TryGetPropertyType(propertyName, CoolingDevicesConfig.FanPropertyTypes, out type);

            return GetConvertedPropertyValue(value, type);
        }
    }
}
