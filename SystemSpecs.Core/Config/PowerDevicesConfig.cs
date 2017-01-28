using System;
using System.Collections.Generic;
using SystemSpecs.Core.Enums;

namespace SystemSpecs.Core.Config
{
    public static class PowerDevicesConfig
    {
        public static Dictionary<string, Type> BatteryPropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "BatteryRechargeTime", typeof(uint) },
            { "BatteryStatus", typeof(BatteryStatus) },
            { "Caption", typeof(string) },
            { "Chemistry", typeof(Chemistry) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "Description", typeof(string) },
            { "DesignCapacity", typeof(uint) },
            { "DesignVoltage", typeof(ulong) },
            { "DeviceID", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "EstimatedChargeRemaining", typeof(ushort) },
            { "EstimatedRunTime", typeof(uint) },
            { "ExpectedBatteryLife", typeof(uint) },
            { "ExpectedLife", typeof(uint) },
            { "FullChargeCapacity", typeof(uint) },
            { "InstallDate", typeof(string) }, // datetime
            { "LastErrorCode", typeof(uint) },
            { "MaxRechargeTime", typeof(uint) },
            { "Name", typeof(string) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "SmartBatteryVersion", typeof(string) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
            { "TimeOnBattery", typeof(uint) },
            { "TimeToFullCharge", typeof(uint) },
        };

        public static Dictionary<string, Type> CurrentProbePropertyTypes = new Dictionary<string, Type>
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

        public static Dictionary<string, Type> PortableBatteryPropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "BatteryStatus", typeof(BatteryStatus) },
            { "CapacityMultiplier", typeof(ushort) },
            { "Caption", typeof(string) },
            { "Chemistry", typeof(Chemistry) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "Description", typeof(string) },
            { "DesignCapacity", typeof(uint) },
            { "DesignVoltage", typeof(ulong) },
            { "DeviceID", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "EstimatedChargeRemaining", typeof(ushort) },
            { "EstimatedRunTime", typeof(uint) },
            { "ExpectedBatteryLife", typeof(uint) },
            { "ExpectedLife", typeof(uint) },
            { "FullChargeCapacity", typeof(uint) },
            { "InstallDate", typeof(string) }, // datetime
            { "LastErrorCode", typeof(uint) },
            { "Location", typeof(string) },
            { "ManufactureDate", typeof(string) },
            { "Manufacturer", typeof(string) },
            { "MaxBatteryError", typeof(ushort) },
            { "MaxRechargeTime", typeof(uint) },
            { "Name", typeof(string) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "SmartBatteryVersion", typeof(string) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
            { "TimeOnBattery", typeof(uint) },
            { "TimeToFullCharge", typeof(uint) },
        };

        public static Dictionary<string, Type> PowerManagementEventPropertyTypes = new Dictionary<string, Type>
        {
            { "SECURITY_DESCRIPTOR", typeof(ushort[]) },
            { "TIME_CREATED", typeof(ulong) },
            { "EventType", typeof(ushort) },
            { "OEMEventCode", typeof(ushort) },
        };

        public static Dictionary<string, Type> VoltageProbeEventPropertyTypes = new Dictionary<string, Type>
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
