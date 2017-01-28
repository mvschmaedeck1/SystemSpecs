using System;
using System.Management;
using SystemSpecs.Core.Config;

namespace SystemSpecs.Core.Hardware
{
    public class Refrigeration : BaseHardware
    {
        private ManagementBaseObject _RefrigerationObject;

        public Refrigeration(ManagementBaseObject genericObject)
        {
            _RefrigerationObject = genericObject;
        }

        public override object GetProperty(string propertyName)
        {
            object value = _RefrigerationObject[propertyName];
            Type type;

            TryGetPropertyType(propertyName, CoolingDevicesConfig.RefrigerationPropertyTypes, out type);

            return GetConvertedPropertyValue(value, type);
        }
    }
}