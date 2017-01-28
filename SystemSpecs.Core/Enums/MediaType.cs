using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum MediaType
    {
        [Description("Unknown")]
        Unknown,

        [Description("Other")]
        Other,

        [Description("Tape Cartridge")]
        TapeCartridge,

        [Description("QIC Cartridge")]
        QICCartridge,

        [Description("AIT Cartridge")]
        AITCartridge,

        [Description("DTF Cartridge")]
        DTFCartridge,

        [Description("DAT Cartridge")]
        DATCartridge,

        [Description("8mm Tape Cartridge")]
        _8mmTapeCartridge,

        [Description("19mm Tape Cartridge")]
        _19mmTapeCartridge,

        [Description("DLT Cartridge")]
        DLTCartridge,

        [Description("Half-Inch Magnetic Tape Cartridge")]
        Half_InchMagneticTapeCartridge,

        [Description("Cartridge Disk")]
        CartridgeDisk,

        [Description("JAZ Disk")]
        JAZDisk,

        [Description("ZIP Disk")]
        ZIPDisk,

        [Description("SyQuest Disk")]
        SyQuestDisk,

        [Description("Winchester Removable Disk")]
        WinchesterRemovableDisk,

        [Description("CD-ROM")]
        CD_ROM,

        [Description("CD-ROM/XA")]
        CD_ROM_XA,

        [Description("CD-I")]
        CD_I,

        [Description("CD Recordable")]
        CDRecordable,

        [Description("WORM")]
        WORM,

        [Description("Magneto-Optical")]
        Magneto_Optical,

        [Description("DVD")]
        DVD,

        [Description("DVD+RW")]
        DVD_RW,

        [Description("DVD-RAM")]
        DVD_RAM,

        [Description("DVD-ROM")]
        DVD_ROM,

        [Description("DVD-Video")]
        DVD_Video,

        [Description("Divx")]
        Divx,

        [Description("Floppy/Diskette")]
        Floppy_Diskette,

        [Description("Hard Disk")]
        HardDisk,

        [Description("Memory Card")]
        MemoryCard,

        [Description("Hard Copy")]
        HardCopy,

        [Description("Clik Disk")]
        ClikDisk,

        [Description("CD-RW")]
        CD_RW,

        [Description("CD-DA")]
        CD_DA,

        [Description("CD+")]
        CDPlus,

        [Description("DVD Recordable")]
        DVDRecordable,

        [Description("DVD-RW")]
        DVD_RW_2,

        [Description("DVD-Audio")]
        DVD_Audio,

        [Description("DVD-5")]
        DVD_5,

        [Description("DVD-9")]
        DVD_9,

        [Description("DVD-10")]
        DVD_10,

        [Description("DVD-18")]
        DVD_18,

        [Description("Magneto-Optical Rewriteable")]
        Magneto_OpticalRewriteable,

        [Description("Magneto-Optical Write Once")]
        Magneto_OpticalWriteOnce,

        [Description("Magneto-Optical Rewriteable (LIMDOW)")]
        Magneto_OpticalRewriteable_LIMDOW,

        [Description("Phase Change Write Once")]
        PhaseChangeWriteOnce,

        [Description("Phase Change Rewriteable")]
        PhaseChangeRewriteable,

        [Description("Phase Change Dual Rewriteable")]
        PhaseChangeDualRewriteable,

        [Description("Ablative Write Once")]
        AblativeWriteOnce,

        [Description("Near Field Recording")]
        NearFieldRecording,

        [Description("MiniQic")]
        MiniQic,

        [Description("Travan")]
        Travan,

        [Description("8mm Metal Particle")]
        _8mmMetalParticle,

        [Description("8mm Advanced Metal Evaporate")]
        _8mmAdvancedMetalEvaporate,

        [Description("NCTP")]
        NCTP,

        [Description("LTO Ultrium")]
        LTOUltrium,

        [Description("LTO Accelis")]
        LTOAccelis,

        [Description("9 Track Tape")]
        _9TrackTape,

        [Description("18 Track Tape")]
        _18TrackTape,

        [Description("36 Track Tape")]
        _36TrackTape,

        [Description("Magstar 3590")]
        Magstar3590,

        [Description("Magstar MP")]
        MagstarMP,

        [Description("D2 Tape")]
        D2Tape,

        [Description("Tape - DST Small")]
        Tape_DSTSmall,

        [Description("Tape - DST Medium")]
        Tape_DSTMedium,

        [Description("Tape - DST Large")]
        Tape_DSTLarge,
    }
}
