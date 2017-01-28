using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum DisplayType
    {
        [Description("Unknown")]
        Unknown,

        [Description("Other")]
        Other,

        [Description("Multiscan Color")]
        MultiscanColor,

        [Description("Multiscan Monochrome")]
        MultiscanMonochrome,

        [Description("Fixed Frequency Color")]
        FixedFrequencyColor,

        [Description("Fixed Frequency Monochrome")]
        FixedFrequencyMonochrome,
    }
}
