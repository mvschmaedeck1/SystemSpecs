using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum Chemistry
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("Lead Acid")]
        LeadAcid,

        [Description("Nickel Cadmium")]
        NickelCadmium,

        [Description("Nickel Metal Hydride")]
        NickelMetalHydride,

        [Description("Lithium-ion")]
        LithiumIon,

        [Description("Zinc air")]
        ZincAir,

        [Description("Lithium Polymer")]
        LithiumPolymer,
    }
}