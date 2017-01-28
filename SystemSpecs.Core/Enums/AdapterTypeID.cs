using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum AdapterTypeID
    {
        [Description("Ethernet 802.3")]
        Ethernet,

        [Description("Token Ring 802.5")]
        TokenRing,

        [Description("Fiber Distributed Data Interface (FDDI)")]
        FDDI,

        [Description("Wide Area Network (WAN)")]
        WAN,

        [Description("LocalTalk")]
        LocalTalk,

        [Description("Ethernet using DIX header format")]
        EthernetDIX,

        [Description("ARCNET")]
        ARCNET_1,

        [Description("ARCNET(878.2)")]
        ARCNET_2,

        [Description("ATM")]
        ATM,

        [Description("Wireless")]
        Wireless,

        [Description("Infrared Wireless")]
        InfraredWireless,

        [Description("Bpc")]
        Bpc,

        [Description("CoWan")]
        CoWan,

        [Description("1394")]
        _1394
    }
}