using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum Availability
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("Running or Full Power")]
        RunningOrFullPower,

        [Description("Warning")]
        Warning,

        [Description("In Test")]
        InTest,

        [Description("Not Applicable")]
        NotApplicable,

        [Description("Running/Full Power")]
        PowerOff,

        [Description("Power Off")]
        OffLine,

        [Description("Off Duty")]
        OffDuty,

        [Description("Degraded")]
        Degraded,

        [Description("Not Installed")]
        NotInstalled,

        [Description("Install Error")]
        InstallError,

        [Description("Power Save - Unknown (the device is known to be in a power save state, but its exact status is unknown)")]
        PowerSaveUnknown,

        [Description("Power Save - Low Power Mode (the device is in a power save state, but still functioning, and may exhibit degraded performance)")]
        PowerSaveLowPowerMode,

        [Description("Power Save - Standby (the device is not functioning, but could be brought to full power quickly)")]
        PowerSaveStandby,

        [Description("Power Cycle")]
        PowerCycle,

        [Description("Power Save - Warning (the device is in a warning state, though also in a power save state)")]
        PowerSaveWarning,

        [Description("Paused (the device is paused)")]
        Paused,

        [Description("Not Ready (the device is not ready)")]
        NotReady,

        [Description("Not Configured (the device is not configured)")]
        NotConfigured,

        [Description("Quiesced (the device is quiet)")]
        Quiesced,
    }
}