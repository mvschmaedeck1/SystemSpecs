using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum PowerManagementCapabilities
    {
        [Description("Unknown")]
        Unknown,

        [Description("Not Supported")]
        NotSupported,

        [Description("Disabled")]
        Disabled,

        [Description("Enabled (the power management features are currently enabled but the exact feature set is unknown or the information is unavailable)")]
        Enabled,

        [Description("Power Saving Modes Entered Automatically (the device can change its power state based on usage or other criteria)")]
        PowerSavingModesEnteredAutomatically,

        [Description("Power State Settable")]
        PowerStateSettable,

        [Description("Power Cycling Supported")]
        PowerCyclingSupported,

        [Description("Timed Power-On Supported")]
        TimedPowerOnSupported

    }
}