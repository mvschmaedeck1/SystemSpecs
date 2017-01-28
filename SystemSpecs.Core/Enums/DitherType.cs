using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum DitherType
    {
        [Description("No dithering")]
        NoDithering = 1,

        [Description("Dithering with a coarse brush")]
        DitheringWithDoarseBrush,

        [Description("Dithering with a fine brush")]
        DitheringWithFineBrush,

        [Description("Line art dithering")]
        LineArtDithering,

        [Description("Device does gray scaling")]
        DeviceDoesGrayScaling,
    }
}
