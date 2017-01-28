using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum Password
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("Disabled")]
        Disabled,

        [Description("Enabled")]
        Enabled,

        [Description("Not Implemented")]
        NotImplemented
    }
}