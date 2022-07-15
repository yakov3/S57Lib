using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public class VRID
    {
        public VRID(IEnumerator i)
        {
            RCNM = (RCNM)ArrayReader.ReadByte(i);
            RCID = ArrayReader.ReadUInt(i);
            RVER = ArrayReader.ReadUShort(i);
            RUIN = (RUIN)ArrayReader.ReadByte(i);
        }
        public RCNM RCNM { get; set; }
        public uint RCID { get; set; }
        public ushort RVER { get; set; }
        public RUIN RUIN { get; set; }
        public List<ATTV> ATTVS { get; set; }
        public VRPC VRPC { get; set; }
        public List<VRPT> VRPTS { get; set; }
        public SGCC SGCC { get; set; }
        public List<SG2D> SG2DS { get; set; }
        public List<SG3D> SG3DS { get; set; }
        public List<ARCC> ARCCS { get; set; }
    }
}
