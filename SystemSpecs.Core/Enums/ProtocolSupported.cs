using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum ProtocolSupported
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("EISA")]
        EISA,

        [Description("ISA")]
        ISA,

        [Description("PCI")]
        PCI,

        [Description("ATA/ATAPI")]
        ATA_ATAPI,

        [Description("Flexible Diskette")]
        FlexibleDiskette,

        [Description("1496")]
        _1496,

        [Description("SCSI Parallel Interface")]
        SCSIParallelInterface,

        [Description("SCSI Fibre Channel Protocol")]
        SCSIFibreChannelProtocol,

        [Description("SCSI Serial Bus Protocol")]
        SCSISerialBusProtocol,

        [Description("SCSI Serial Bus Protocol-2 (1394)")]
        SCSISerialBusProtocol_2_1394,

        [Description("SCSI Serial Storage Architecture")]
        SCSISerialStorageArchitecture,

        [Description("VESA")]
        VESA,

        [Description("PCMCIA")]
        PCMCIA,

        [Description("Universal Serial Bus")]
        UniversalSerialBus,

        [Description("Parallel Protocol")]
        ParallelProtocol,

        [Description("ESCON")]
        ESCON,

        [Description("Diagnostic")]
        Diagnostic,

        [Description("I2C")]
        I2C,

        [Description("Power")]
        Power,

        [Description("HIPPI")]
        HIPPI,

        [Description("MultiBus")]
        MultiBus,

        [Description("VME")]
        VME,

        [Description("IPI")]
        IPI,

        [Description("IEEE-488")]
        IEEE_488,

        [Description("RS232")]
        RS232,

        [Description("IEEE 802.3 10BASE5")]
        IEEE802_310BASE5,

        [Description("IEEE 802.3 10BASE2")]
        IEEE802_310BASE2,

        [Description("IEEE 802.3 1BASE5")]
        IEEE802_31BASE5,

        [Description("IEEE 802.3 10BROAD36")]
        IEEE802_310BROAD36,

        [Description("IEEE 802.3 100BASEVG")]
        IEEE802_3100BASEVG,

        [Description("IEEE 802.5 Token-Ring")]
        IEEE802_5Token_Ring,

        [Description("ANSI X3T9.5 FDDI")]
        ANSIX3T9_5FDDI,

        [Description("MCA")]
        MCA,

        [Description("ESDI")]
        ESDI,

        [Description("IDE")]
        IDE,

        [Description("CMD")]
        CMD,

        [Description("ST506")]
        ST506,

        [Description("DSSI")]
        DSSI,

        [Description("QIC2")]
        QIC2,

        [Description("Enhanced ATA/IDE")]
        EnhancedATAorIDE,

        [Description("AGP")]
        AGP,

        [Description("TWIRP (two-way infrared)")]
        TWIRP_two_wayinfrared,

        [Description("FIR (fast infrared)")]
        FIR_fastinfrared,

        [Description("SIR (serial infrared)")]
        SIR_serialinfrared,

        [Description("IrBus")]
        IrBus,
    }
}
