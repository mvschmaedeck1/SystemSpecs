using System;
using System.Collections.Generic;
using SystemSpecs.Core.Enums;

namespace SystemSpecs.Core.Config
{
    public static class CoolingDevicesConfig
    {
        public static Dictionary<string, Type> FanPropertyTypes = new Dictionary<string, Type>
        {
            { "ActiveCooling", typeof(bool) },
            { "Availability", typeof(Availability) },
            { "Caption", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "Description", typeof(string) },
            { "DesiredSpeed", typeof(ulong) },
            { "DeviceID", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "LastErrorCode", typeof(uint) },
            { "Name", typeof(string) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
            { "VariableSpeed", typeof(bool) },
        };

        public static Dictionary<string, Type> HeatPipePropertyTypes = new Dictionary<string, Type>
        {
            { "ActiveCooling", typeof(bool) },
            { "Availability", typeof(Availability) },
            { "Caption", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "LastErrorCode", typeof(uint) },
            { "Name", typeof(string) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
        };

        public static Dictionary<string, Type> RefrigerationPropertyTypes = new Dictionary<string, Type>
        {
            { "ActiveCooling", typeof(bool) },
            { "Availability", typeof(Availability) },
            { "Caption", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "LastErrorCode", typeof(uint) },
            { "Name", typeof(string) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
        };

        public static Dictionary<string, Type> TemperatureProbePropertyTypes = new Dictionary<string, Type>
        {
            { "Accuracy", typeof(int) },
            { "Availability", typeof(Availability) },
            { "Caption", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "CurrentReading", typeof(int) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "IsLinear", typeof(bool) },
            { "LastErrorCode", typeof(uint) },
            { "LowerThresholdCritical", typeof(int) },
            { "LowerThresholdFatal", typeof(int) },
            { "LowerThresholdNonCritical", typeof(int) },
            { "MaxReadable", typeof(int) },
            { "MinReadable", typeof(int) },
            { "Name", typeof(string) },
            { "NominalReading", typeof(int) },
            { "NormalMax", typeof(int) },
            { "NormalMin", typeof(int) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "Resolution", typeof(uint) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
            { "Tolerance", typeof(int) },
            { "UpperThresholdCritical", typeof(int) },
            { "UpperThresholdFatal", typeof(int) },
            { "UpperThresholdNonCritical", typeof(int) },
        };
    }
}
