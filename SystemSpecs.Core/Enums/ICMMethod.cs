using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum ICMMethod
    {
        [Description("Disabled")]
        Disabled,

        [Description("Windows")]
        Windows,

        [Description("Device Driver")]
        DeviceDriver,

        [Description("Destination Device")]
        DestinationDevice,
    }
}
