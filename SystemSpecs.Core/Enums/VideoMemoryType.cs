using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum VideoMemoryType
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("VRAM")]
        VRAM,

        [Description("DRAM")]
        DRAM,

        [Description("SRAM")]
        SRAM,

        [Description("WRAM")]
        WRAM,

        [Description("EDO RAM")]
        EDO_RAM,

        [Description("Burst Synchronous DRAM")]
        BurstSynchronousDRAM,

        [Description("Pipelined Burst SRAM")]
        PipelinedBurstSRAM,

        [Description("CDRAM")]
        CDRAM,

        [Description("3DRAM")]
        _3DRAM,

        [Description("SDRAM")]
        SDRAM,

        [Description("SGRAM")]
        SGRAM,
    }
}
