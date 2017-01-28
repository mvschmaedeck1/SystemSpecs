using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSpecs.Core.Enums
{
    public enum VideoArchitecture
    {
        [Description("Other")]
        Other = 1,

        [Description("Unknown")]
        Unknown,

        [Description("CGA")]
        CGA,

        [Description("EGA")]
        EGA,

        [Description("VGA")]
        VGA,

        [Description("SVGA"]
        SVGA,

        [Description("MDA")]
        MDA,

        [Description("HGC")]
        HGC,

        [Description("MCGA")]
        MCGA,

        [Description("8514A")]
        _8514A,

        [Description("XGA")]
        XGA,

        [Description("Linear Frame Buffer")]
        LinearFrameBuffer,

        [Description("PC-98")]
        PC_98,
    }
}
