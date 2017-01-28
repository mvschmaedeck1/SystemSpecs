using System;
using System.Management;
using SystemSpecs.Core.Config;

namespace SystemSpecs.Core.Hardware.NetworkDevices
{
    public class NetworkAdapter : BaseHardware
    {
        private ManagementBaseObject _AdapterObject;
        private ManagementBaseObject _AdapterConfigurationObject;
        
        public NetworkAdapter(ManagementBaseObject adapterObject, ManagementBaseObject adapterConfigurationObject)
        {
            _AdapterObject = adapterObject;
            _AdapterConfigurationObject = adapterConfigurationObject;
        }

        public override object GetProperty(string propertyName)
        {
            Type type;
            object value = null;

            if (TryGetPropertyType(propertyName, NetworkingDevicesConfig.DefaultPropertiesTypesForAdapter, out type))
            {
                value = _AdapterObject[propertyName];
            }
            else if(TryGetPropertyType(propertyName, NetworkingDevicesConfig.DefaultPropertiesTypesForAdapterConfiguration, out type))
            {
                value = _AdapterConfigurationObject[propertyName];
            }

            return GetConvertedPropertyValue(value, type);
        }
    }
}