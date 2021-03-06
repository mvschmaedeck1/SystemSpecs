﻿using System;
using System.Collections.Generic;
using SystemSpecs.Core.Enums;

namespace SystemSpecs.Core.Config
{
    public class MassStorageDevicesConfig
    {
        public static Dictionary<string, Type> AutochkSettingsPropertyTypes = new Dictionary<string, Type>
        {
            { "Caption", typeof(string) },
            { "Description", typeof(string) },
            { "SettingID", typeof(string) },
            { "UserInputDelay", typeof(uint) },
        };

        public static Dictionary<string, Type> CDROMDrivePropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "Capabilities", typeof(Capabilities[]) },
            { "CapabilityDescriptions", typeof(string[]) },
            { "Caption", typeof(string) },
            { "CompressionMethod", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "DefaultBlockSize", typeof(ulong) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "Drive", typeof(string) },
            { "DriveIntegrity", typeof(bool) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "ErrorMethodology", typeof(string) },
            { "FileSystemFlags", typeof(ushort) },
            { "FileSystemFlagsEx", typeof(FileSystemFlagsEx) },
            { "Id", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "LastErrorCode", typeof(uint) },
            { "Manufacturer", typeof(string) },
            { "MaxBlockSize", typeof(ulong) },
            { "MaximumComponentLength", typeof(uint) },
            { "MaxMediaSize", typeof(ulong) },
            { "MediaLoaded", typeof(bool) },
            { "MediaType", typeof(string) },
            { "MfrAssignedRevisionLevel", typeof(string) },
            { "MinBlockSize", typeof(ulong) },
            { "Name", typeof(string) },
            { "NeedsCleaning", typeof(bool) },
            { "NumberOfMediaSupported", typeof(uint) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "RevisionLevel", typeof(string) },
            { "SCSIBus", typeof(uint) },
            { "SCSILogicalUnit", typeof(ushort) },
            { "SCSIPort", typeof(ushort) },
            { "SCSITargetId", typeof(ushort) },
            { "SerialNumber", typeof(string) },
            { "Size", typeof(ulong) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
            { "TransferRate", typeof(double) },
            { "VolumeName", typeof(string) },
            { "VolumeSerialNumber", typeof(string) },
        };

        public static Dictionary<string, Type> DiskDrivePropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "BytesPerSector", typeof(uint) },
            { "Capabilities", typeof(Capabilities[]) },
            { "CapabilityDescriptions", typeof(string[]) },
            { "Caption", typeof(string) },
            { "CompressionMethod", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "DefaultBlockSize", typeof(ulong) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "ErrorMethodology", typeof(string) },
            { "FirmwareRevision", typeof(string) },
            { "Index", typeof(uint) },
            { "InstallDate", typeof(string) }, // datetime
            { "InterfaceType", typeof(string) },
            { "LastErrorCode", typeof(uint) },
            { "Manufacturer", typeof(string) },
            { "MaxBlockSize", typeof(ulong) },
            { "MaxMediaSize", typeof(ulong) },
            { "MediaLoaded", typeof(bool) },
            { "MediaType", typeof(string) },
            { "MinBlockSize", typeof(ulong) },
            { "Model", typeof(string) },
            { "Name", typeof(string) },
            { "NeedsCleaning", typeof(bool) },
            { "NumberOfMediaSupported", typeof(uint) },
            { "Partitions", typeof(uint) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "SCSIBus", typeof(uint) },
            { "SCSILogicalUnit", typeof(ushort) },
            { "SCSIPort", typeof(ushort) },
            { "SCSITargetId", typeof(ushort) },
            { "SectorsPerTrack", typeof(uint) },
            { "SerialNumber", typeof(string) },
            { "Signature", typeof(uint) },
            { "Size", typeof(ulong) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
            { "TotalCylinders", typeof(ulong) },
            { "TotalHeads", typeof(uint) },
            { "TotalSectors", typeof(ulong) },
            { "TotalTracks", typeof(ulong) },
            { "TracksPerCylinder", typeof(uint) },
        };

        public static Dictionary<string, Type> FloppyDrivePropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "Capabilities", typeof(Capabilities[]) },
            { "CapabilityDescriptions", typeof(string[]) },
            { "Caption", typeof(string) },
            { "CompressionMethod", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "DefaultBlockSize", typeof(ulong) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "ErrorMethodology", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "LastErrorCode", typeof(uint) },
            { "Manufacturer", typeof(string) },
            { "MaxBlockSize", typeof(ulong) },
            { "MaxMediaSize", typeof(ulong) },
            { "MinBlockSize", typeof(ulong) },
            { "Name", typeof(string) },
            { "NeedsCleaning", typeof(bool) },
            { "NumberOfMediaSupported", typeof(uint) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
        };

        public static Dictionary<string, Type> PhysicalMediaPropertyTypes = new Dictionary<string, Type>
        {
            { "Caption", typeof(string) },
            { "Description", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "Name", typeof(string) },
            { "Status", typeof(string) },
            { "CreationClassName", typeof(string) },
            { "Manufacturer", typeof(string) },
            { "Model", typeof(string) },
            { "SKU", typeof(string) },
            { "SerialNumber", typeof(string) },
            { "Tag", typeof(string) },
            { "Version", typeof(string) },
            { "PartNumber", typeof(string) },
            { "OtherIdentifyingInfo", typeof(string) },
            { "PoweredOn", typeof(bool) },
            { "Removable", typeof(bool) },
            { "Replaceable", typeof(bool) },
            { "HotSwappable", typeof(bool) },
            { "Capacity", typeof(ulong) },
            { "MediaType", typeof(MediaType) },
            { "MediaDescription", typeof(string) },
            { "WriteProtectOn", typeof(bool) },
            { "CleanerMedia", typeof(bool) },
        };

        public static Dictionary<string, Type> TapeDrivePropertyTypes = new Dictionary<string, Type>
        {
            { "Availability", typeof(Availability) },
            { "Capabilities", typeof(Capabilities[]) },
            { "CapabilityDescriptions", typeof(string[]) },
            { "Caption", typeof(string) },
            { "Compression", typeof(uint) },
            { "CompressionMethod", typeof(string) },
            { "ConfigManagerErrorCode", typeof(ConfigManagerErrorCode) },
            { "ConfigManagerUserConfig", typeof(bool) },
            { "CreationClassName", typeof(string) },
            { "DefaultBlockSize", typeof(ulong) },
            { "Description", typeof(string) },
            { "DeviceID", typeof(string) },
            { "ECC", typeof(uint) },
            { "EOTWarningZoneSize", typeof(uint) },
            { "ErrorCleared", typeof(bool) },
            { "ErrorDescription", typeof(string) },
            { "ErrorMethodology", typeof(string) },
            { "FeaturesHigh", typeof(uint) },
            { "FeaturesLow", typeof(uint) },
            { "Id", typeof(string) },
            { "InstallDate", typeof(string) }, // datetime
            { "LastErrorCode", typeof(uint) },
            { "Manufacturer", typeof(string) },
            { "MaxBlockSize", typeof(ulong) },
            { "MaxMediaSize", typeof(ulong) },
            { "MaxPartitionCount", typeof(uint) },
            { "MediaType", typeof(string) },
            { "MinBlockSize", typeof(ulong) },
            { "Name", typeof(string) },
            { "NeedsCleaning", typeof(bool) },
            { "NumberOfMediaSupported", typeof(uint) },
            { "Padding", typeof(uint) },
            { "PNPDeviceID", typeof(string) },
            { "PowerManagementCapabilities", typeof(PowerManagementCapabilities[]) },
            { "PowerManagementSupported", typeof(bool) },
            { "ReportSetMarks", typeof(uint) },
            { "Status", typeof(string) },
            { "StatusInfo", typeof(StatusInfo) },
            { "SystemCreationClassName", typeof(string) },
            { "SystemName", typeof(string) },
        };
    }
}
