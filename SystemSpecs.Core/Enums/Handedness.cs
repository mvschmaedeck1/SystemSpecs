using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum Handedness
    {
        [Description("Unknown")]
        Unknown,

        [Description("Not Applicable")]
        NotApplicable,

        [Description("Right Handed Operation")]
        RightHandedOperation,

        [Description("Left Handed Operation")]
        LeftHandedOperation
    }
}