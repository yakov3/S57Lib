using S57Lib.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public enum DSTR 
    {
        CS=1,
        CN,
        PG,
        FT,
        NO=255
    }
    public class DSSI
    {
        public DSSI(IEnumerator i) 
        {
            DSTR = (DSTR)ArrayReader.ReadByte(i);
            AALL = ArrayReader.ReadByte(i);
            Reader.AALL = AALL;
            NALL = ArrayReader.ReadByte(i);
            Reader.NALL = NALL;
            NOMR = ArrayReader.ReadUInt(i);
            NOCR = ArrayReader.ReadUInt(i);
            NOGR = ArrayReader.ReadUInt(i);
            NOLR = ArrayReader.ReadUInt(i);
            NOIN = ArrayReader.ReadUInt(i);
            NOCN = ArrayReader.ReadUInt(i);
            NOED = ArrayReader.ReadUInt(i);
            NOFA = ArrayReader.ReadUInt(i);
        }
        public DSTR DSTR { get; set; }
        public byte AALL { get; set; }
        public byte NALL { get; set; }
        public uint NOMR { get; set; }
        public uint NOCR { get; set; }
        public uint NOGR { get; set; }
        public uint NOLR { get; set; }
        public uint NOIN { get; set; }
        public uint NOCN { get; set; }
        public uint NOED { get; set; }
        public uint NOFA { get; set; }
        public override string ToString()
        {
            return $"DSTR {DSTR} AALL {AALL} NALL {NALL} NOMR {NOMR} NOCR {NOCR} NOGR {NOGR} NOLR {NOLR} NOIN {NOIN} NOCN {NOCN} NOED {NOED} NOFA {NOFA}";
        }
    }
}
