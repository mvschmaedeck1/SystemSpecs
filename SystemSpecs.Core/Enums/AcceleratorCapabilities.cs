using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum AcceleratorCapabilities
    {
        [Description("Unknown")]
        Unknown,

        [Description("Other")]
        Other,

        [Description("Graphics Accelerator")]
        GraphicsAccelerator,

        [Description("3D Accelerator")]
        _3DAccelerator
    }
}
