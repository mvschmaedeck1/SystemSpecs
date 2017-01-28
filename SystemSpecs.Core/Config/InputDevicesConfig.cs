using System;
using System.Collections.Generic;
using SystemSpecs.Core.Enums;

namespace SystemSpecs.Core.Config
{
    public static class InputDevicesConfig
    {
        public static Dictionary<string, Type> PointingDevicePropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "Caption", typeof(string)},
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool)},
            { "CreationClassName", typeof(string)},
            { "Description", typeof(string)},
            { "DeviceID", typeof(string)},
            { "DeviceInterface", typeof(DeviceInterface) },
            { "DoubleSpeedThreshold", typeof(uint)},
            { "ErrorCleared", typeof(bool)},
            { "ErrorDescription", typeof(string)},
            { "Handedness", typeof(Handedness) },
            { "HardwareType", typeof(string)},
            { "InfFileName", typeof(string)},
            { "InfSection", typeof(string)},
            { "InstallDate", typeof(string)}, // datetime
            { "IsLocked", typeof(bool)},
            { "LastErrorCode", typeof(uint)},
            { "Manufacturer", typeof(string)},
            { "Name", typeof(string)},
            { "NumberOfButtons", typeof(ushort)},
            { "PNPDeviceID", typeof(string)},
            { "PointingType", typeof(PointingType) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool)},
            { "QuadSpeedThreshold", typeof(uint)},
            { "Resolution", typeof(uint)},
            { "SampleRate", typeof(uint)},
            { "Status", typeof(string)},
            { "StatusInfo", typeof(StatusInfo) },
            { "Synch", typeof(uint)},
            { "SystemCreationClassName", typeof(string)},
            { "SystemName", typeof(string)},
        };

        public static Dictionary<string, Type> KeyboardPropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "Caption", typeof(string)},
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool)},
            { "CreationClassName", typeof(string)},
            { "Description", typeof(string)},
            { "DeviceID", typeof(string)},
            { "ErrorCleared", typeof(bool)},
            { "ErrorDescription", typeof(string)},
            { "InstallDate", typeof(string)}, // datetime
            { "IsLocked", typeof(bool)},
            { "LastErrorCode", typeof(uint)},
            { "Layout", typeof(string)},
            { "Name", typeof(string)},
            { "NumberOfFunctionKeys", typeof(ushort)},
            { "Password", typeof(Password)},
            { "PNPDeviceID", typeof(string)},
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool)},
            { "Status", typeof(string)},
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string)},
            { "SystemName", typeof(string)},
        };
    }
}
