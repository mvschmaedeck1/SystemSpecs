using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum ICMIntent
    {
        [Description("Saturation")]
        Saturation = 1,

        [Description("Contrast")]
        Contrast,

        [Description("Exact Color")]
        ExactColor,
    }
}
