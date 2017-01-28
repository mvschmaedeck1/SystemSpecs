using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecs.Core.Hardware
{
    public class GenericHardware : BaseHardware
    {
        private ManagementBaseObject _HardwareObject;
        private Dictionary<string, Type> _PropertyTypes;

        public GenericHardware(ManagementBaseObject hardwareObject, Dictionary<string, Type> propertyTypes)
        {
            _HardwareObject = hardwareObject;
            _PropertyTypes = propertyTypes;
        }

        public override object GetProperty(string propertyName)
        {
            object value = _HardwareObject[propertyName];

            Type type;

            TryGetPropertyType(propertyName, _PropertyTypes, out type);

            return GetConvertedPropertyValue(value, type);
        }
    }
}
