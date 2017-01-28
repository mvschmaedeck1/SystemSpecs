using System;
using System.Management;
using SystemSpecs.Core.Config;

namespace SystemSpecs.Core.Hardware.InputDevices
{
    public class PointingDevice : BaseHardware
    {
        private ManagementBaseObject _PointingDeviceObject;

        public PointingDevice(ManagementBaseObject pointingDeviceObject)
        {
            _PointingDeviceObject = pointingDeviceObject;
        }

        public override object GetProperty(string propertyName)
        {
            object value = _PointingDeviceObject[propertyName];
            Type type;

            TryGetPropertyType(propertyName, InputDevicesConfig.PointingDevicePropertyTypes, out type);

            return GetConvertedPropertyValue(value, type);
        }
    }
}