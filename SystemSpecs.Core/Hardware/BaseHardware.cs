using System;
using System.Collections.Generic;

namespace SystemSpecs.Core.Hardware
{
    public abstract class BaseHardware
    {
        public abstract object GetProperty(string propertyName);

        protected T CastProperty<T>(object value)
        {
            return (T)value;
        }

        protected object GetConvertedPropertyValue(object value, Type destinationType)
        {
            if(value == null)
            {
                return null;
            }

            else if (destinationType == typeof(object))
            {
                return value;
            }

            else if (destinationType.IsEnum)
            {
                return Enum.ToObject(destinationType, value);
            }

            else
            {
                return Convert.ChangeType(value, destinationType);
            }
        }

        protected bool TryGetPropertyType(string propertyName, Dictionary<string, Type> configDictionary, out Type objectType)
        {
            if(configDictionary.TryGetValue(propertyName, out objectType))
            {
                return true;
            }
            else
            {
                objectType = typeof(object);
                return false;
            }            
        }
    }
}