using System.Collections.Generic;

namespace SystemSpecs.Core.Config
{
    public static class DisplayedPropertiesConfig
    {
        public static readonly IEnumerable<string> NetworkAdapterDefaultDisplayedProperties = new List<string>
        {
            "AdapterType",
            "Availability",
            "Caption",
            "ConfigManagerErrorCode",
            "ConfigManagerUserConfig",
            "Description",
            "DeviceID",
            "GUID",
            "Installed",
            "InterfaceIndex",
            "MACAdress",
            "Manufacturer",
            "MaxNumberControlled",
            "Name",
            "NetConnectionID",
            "NetConnectionStatus",
            "NetEnabled",
            "PhysicalAdapter",
            "PNPDeviceID",
            "PowerManagementSupported",
            "ProductName",
            "ServiceName",
            "Speed",
            "SystemCreationClassName"
        };
    }
}
