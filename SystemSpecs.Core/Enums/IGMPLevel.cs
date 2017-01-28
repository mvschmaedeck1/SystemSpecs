using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum IGMPLevel
    {
        [Description("No Multicast")]
        NoMulticast,

        [Description("IP Multicast")]
        IPMulticast,

        [Description("IP & IGMP multicast (default)")]
        IPAndIGMPMulticast
    }
}