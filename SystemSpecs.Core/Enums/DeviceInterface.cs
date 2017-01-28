using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum DeviceInterface
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("Serial")]
        Serial,

        [Description("PS/2")]
        PS2,

        [Description("Infrared")]
        Infrared,

        [Description("HP-HIL")]
        HP_HIL,

        [Description("Bus mouse")]
        BusMouse,

        [Description("ADB (Apple Desktop Bus)")]
        ADB,

        [Description("Bus mouse DB-9")]
        BusMouseDB9 = 160,

        [Description("Bus mouse micro-DIN")]
        BusMouseMicroDIN = 161,

        [Description("USB")]
        USB = 162
    }
}