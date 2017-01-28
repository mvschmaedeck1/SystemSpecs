using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum StatusInfo
    {
        [Description("Other")]
        Other,

        [Description("Unknown")]
        Unknown,

        [Description("Enabled")]
        Enabled,

        [Description("Disabled")]
        Disabled,

        [Description("Not Applicable")]
        NotApplicable
    }
}