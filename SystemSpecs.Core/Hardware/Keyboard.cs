using System;
using System.Management;
using SystemSpecs.Core.Config;

namespace SystemSpecs.Core.Hardware
{
    public class Keyboard : BaseHardware
    {
        private ManagementBaseObject _KeyboardObject;

        public Keyboard(ManagementBaseObject keyboardObject)
        {
            _KeyboardObject = keyboardObject;
        }

        public override object GetProperty(string propertyName)
        {
            object value = _KeyboardObject[propertyName];
            Type type;

            TryGetPropertyType(propertyName, InputDevicesConfig.KeyboardPropertyTypes, out type);

            return GetConvertedPropertyValue(value, type);
        }
    }
}