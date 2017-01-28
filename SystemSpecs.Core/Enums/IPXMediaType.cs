using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum IPXMediaType
    {
        [Description("Ethernet")]
        Ethernet,

        [Description("Token ring")]
        TokenRing,

        [Description("FDDI")]
        FDDI,

        [Description("ARCNET")]
        ARCNET,


    }
}