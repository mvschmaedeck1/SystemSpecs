using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum NetConnectionStatus
    {
        [Description("Disconnected")]
        Disconnected,

        [Description("Connecting")]
        Connecting,

        [Description("Connected")]
        Connected,

        [Description("Disconnecting")]
        Disconnecting,

        [Description("Hardware Not Present")]
        HardwareNotPresent,

        [Description("Hardware Disabled")]
        HardwareDisabled,

        [Description("Hardware Malfunction")]
        HardwareMalfunction,

        [Description("Media Disconnected")]
        MediaDisconnected,

        [Description("Authenticating")]
        Authenticating,

        [Description("Authentication Succeeded")]
        AuthenticationSucceeded,

        [Description("Authentication Failed")]
        AuthenticationFailed,

        [Description("Invalid Address")]
        InvalidAddress,

        [Description("Credentials Required")]
        CredentialsRequired,

        [Description("Other")]
        Other
    }
}