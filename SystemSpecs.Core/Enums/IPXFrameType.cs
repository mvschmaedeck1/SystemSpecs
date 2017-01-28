using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum IPXFrameType
    {
        [Description("Ethernet II")]
        Ethernet_II,

        [Description("Ethernet 802.3")]
        Ethernet_802_3,

        [Description("Ethernet 802.2")]
        Ethernet_802_2,

        [Description("Ethernet SNAP")]
        Ethernet_SNAP,

        [Description("AUTO")]
        AUTO = 255,


    }
}