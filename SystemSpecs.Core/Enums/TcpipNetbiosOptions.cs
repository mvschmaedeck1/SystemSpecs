using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum TcpipNetbiosOptions
    {
        [Description("Enable Netbios Via Dhcp")]
        EnableNetbiosViaDhcp,

        [Description("Enable Netbios")]
        EnableNetbios,

        [Description("Disable Netbios")]
        DisableNetbios
    }
}