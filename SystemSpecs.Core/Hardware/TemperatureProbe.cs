using System;
using System.Management;
using SystemSpecs.Core.Config;

namespace SystemSpecs.Core.Hardware
{
    public class TemperatureProbe : BaseHardware
    {
        private ManagementBaseObject TemperatureProbeObject;

        public TemperatureProbe(ManagementBaseObject genericObject)
        {
            TemperatureProbeObject = genericObject;
        }

        public override object GetProperty(string propertyName)
        {
            object value = TemperatureProbeObject[propertyName];
            Type type;

            TryGetPropertyType(propertyName, CoolingDevicesConfig.TemperatureProbePropertyTypes, out type);

            return GetConvertedPropertyValue(value, type);
        }
    }
}
