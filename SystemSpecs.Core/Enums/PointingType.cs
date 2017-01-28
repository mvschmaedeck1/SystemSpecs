using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum PointingType
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("Mouse")]
        Mouse,

        [Description("Track Ball")]
        TrackBall,

        [Description("Track Point")]
        TrackPoint,

        [Description("Glide Point")]
        GlidePoint,

        [Description("Touch Pad")]
        TouchPad,

        [Description("Touch Screen")]
        TouchScreen,

        [Description("Mouse - Optical Sensor")]
        MouseOpticalSensor
    }
}