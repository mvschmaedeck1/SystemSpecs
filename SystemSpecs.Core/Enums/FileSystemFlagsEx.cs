using System.ComponentModel;

namespace SystemSpecs.Core.Enums
{
    public enum FileSystemFlagsEx
    {
        [Description("Case Sensitive Search (the file system supports case-sensitive file names)")]
        CaseSensitiveSearch,

        [Description("Case Preserved Names (the file system preserves the case of file names when it places a name on a disk)")]
        CasePreservedNames,

        [Description("Unicode On Disk (the file system supports Unicode in file names as they appear on the disk)")]
        UnicodeOnDisk = 4,

        [Description("Persistent ACLs (the file system preserves and enforces access control lists(ACLs).For example, the NTFS file system preserves and enforces ACLs and the FAT file system does not)")]
        PersistentACLs = 8,

        [Description("File Compression (the file system supports file - based compression)")]
        FileCompression = 16,

        [Description("Volume Quotas (the file system supports disk quotas)")]
        VolumeQuotas = 32,

        [Description("Supports Sparse Files (the file system supports spare files)")]
        SupportsSparseFiles = 64,

        [Description("Supports Reparse Points (the file system supports reparse points)")]
        SupportsReparsePoints = 128,

        [Description("Supports Remote Storage (the file system supports the remote storage of files)")]
        SupportsRemoteStorage = 256,

        [Description("Supports Long Names (the file system supports file names that are longer than eight characters)")]
        SupportsLongNames = 16384,

        [Description("Volume Is Compressed (the specified disk volume is a compressed volume, for example, a DoubleSpace volume)")]
        VolumeIsCompressed = 32768,

        [Description("Read Only Volume (the specified volume is read - only)")]
        ReadOnlyVolume = 524289,

        [Description("Supports Object IDS (the file system supports object identifiers)")]
        SupportsObjectIDS = 65536,

        [Description("Supports Encryption (the file system supports the Encrypted File System(EFS))")]
        SupportsEncryption = 131072,

        [Description("Supports Named Streams")]
        SupportsNamedStreams = 262144,
    }
}