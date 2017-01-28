using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum BatteryStatus
    {
        [Description("Other (the battery is discharging)")]
        Other = 1,

        [Description("Unknown (The system has access to AC so no battery is being discharged. However, the battery is not necessarily charging)")]
        Unknown,

        [Description("Fully Charged")]
        FullyCharged,

        [Description("Low")]
        Low,

        [Description("Critical")]
        Critical,

        [Description("Charging")]
        Charging,

        [Description("Charging and High")]
        ChargingAndHigh,

        [Description("Charging and Low")]
        ChargingAndLow,

        [Description("Charging and Critical")]
        ChargingAndCritical,

        [Description("Undefined")]
        Undefined,

        [Description("Partially Charged")]
        PartiallyCharged,
    }
}