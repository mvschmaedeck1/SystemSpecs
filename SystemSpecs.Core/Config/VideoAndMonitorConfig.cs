using System;
using System.Collections.Generic;
using SystemSpecs.Core.Enums;

namespace SystemSpecs.Core.Config
{
    public static class VideoAndMonitorConfig
    {
        public static Dictionary<string, Type> DesktopMonitorPropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "Bandwidth", typeof(uint) },
            { "Caption", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "DisplayType", typeof(DisplayType) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "IsLocked", typeof(bool) },
            { "LastErrorCode", typeof(uint) },
            { "MonitorManufacturer", typeof(string) },
            { "MonitorType", typeof(string) },
            { "Name", typeof(string) },
            { "PixelsPerXLogicalInch", typeof(uint) },
            { "PixelsPerYLogicalInch", typeof(uint) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "ScreenHeight", typeof(uint) },
            { "ScreenWidth", typeof(uint) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },

        };

        public static Dictionary<string, Type> DisplayControllerConfigurationPropertyTypes = new Dictionary<string, Type>
        {
            { "Caption", typeof(string) },
            { "Description", typeof(string) },
            { "SettingID", typeof(string) },
            { "BitsPerPixel", typeof(uint) },
            { "ColorPlanes", typeof(uint) },
            { "DeviceEntriesInAColorTable", typeof(uint) },
            { "DeviceSpecificPens", typeof(uint) },
            { "HorizontalResolution", typeof(uint) },
            { "Name", typeof(string) },
            { "RefreshRate", typeof(int) },
            { "ReservedSystemPaletteEntries", typeof(uint) },
            { "SystemPaletteEntries", typeof(uint) },
            { "VerticalResolution", typeof(uint) },
            { "VideoMode", typeof(string) },
        };

        public static Dictionary<string, Type> VideoControllerPropertyTypes = new Dictionary<string, Type>
        {
            { "AcceleratorCapabilities", typeof(AcceleratorCapabilities[]) },
            { "AdapterCompatibility", typeof(string) },
            { "AdapterDACType", typeof(string) },
            { "AdapterRAM", typeof(uint) },
            { "Availability", typeof(Availability) },
            { "CapabilityDescriptions", typeof(string[]) },
            { "Caption", typeof(string) },
            { "ColorTableEntries", typeof(uint) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "CurrentBitsPerPixel", typeof(uint) },
            { "CurrentHorizontalResolution", typeof(uint) },
            { "CurrentNumberOfColors", typeof(ulong) },
            { "CurrentNumberOfColumns", typeof(uint) },
            { "CurrentNumberOfRows", typeof(uint) },
            { "CurrentRefreshRate", typeof(uint) },
            { "CurrentScanMode", typeof(CurrentScanMode) },
            { "CurrentVerticalResolution", typeof(uint) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "DeviceSpecificPens", typeof(uint) },
            { "DitherType", typeof(DitherType) },
            { "DriverDate", typeof(string) }, // datetime
            { "DriverVersion", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "ICMIntent", typeof(ICMIntent) },
            { "ICMMethod", typeof(ICMMethod) },
            { "InfFilename", typeof(string) },
            { "InfSection", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "InstalledDisplayDrivers", typeof(string) },
            { "LastErrorCode", typeof(uint) },
            { "MaxMemorySupported", typeof(uint) },
            { "MaxNumberControlled", typeof(uint) },
            { "MaxRefreshRate", typeof(uint) },
            { "MinRefreshRate", typeof(uint) },
            { "Monochrome", typeof(bool) },
            { "Name", typeof(string) },
            { "NumberOfColorPlanes", typeof(ushort) },
            { "NumberOfVideoPages", typeof(uint) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "ProtocolSupported", typeof(ProtocolSupported) },
            { "ReservedSystemPaletteEntries", typeof(uint) },
            { "SpecificationVersion", typeof(uint) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
            { "SystemPaletteEntries", typeof(uint) },
            { "TimeOfLastReset", typeof(string) }, // datetime
            { "VideoArchitecture", typeof(VideoArchitecture) },
            { "VideoMemoryType", typeof(VideoMemoryType) },
            { "VideoMode", typeof(ushort) },
            { "VideoModeDescription", typeof(string) },
            { "VideoProcessor", typeof(string) },
        };
    }
}
