using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum Capabilities
    {
        [Description("Unknown")]
        Unknown,

        [Description("Other")]
        Other,

        [Description("Sequential Access")]
        SequentialAccess,

        [Description("Random Access")]
        RandomAccess,

        [Description("Supports Writing")]
        SupportsWriting,

        [Description("Encryption")]
        Encryption,

        [Description("Compression")]
        Compression,

        [Description("Supports Removable Media")]
        SupportsRemovableMedia,

        [Description("Manual Cleaning")]
        ManualCleaning,

        [Description("Automatic Cleaning")]
        AutomaticCleaning,

        [Description("SMART Notification")]
        SMARTNotification,

        [Description("Supports Dual-Sided Media")]
        SupportsDualSidedMedia,

        [Description("Predismount Eject Not Required")]
        PredismountEjectNotRequired,
    }
}