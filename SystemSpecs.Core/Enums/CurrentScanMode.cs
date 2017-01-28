using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum CurrentScanMode
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("Interlaced")]
        Interlaced,

        [Description("Non Interlaced")]
        NonInterlaced,
    }
}
