using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{
    public enum PRIM 
    {
        P = 1,
        L,
        A,
        N = 255
    }
    public class FRID
    {
        public FRID(IEnumerator i)
        {
            RCNM = (RCNM)ArrayReader.ReadByte(i);
            RCID = ArrayReader.ReadUInt(i);
            PRIM = ArrayReader.ReadByte(i);
            GRUP = ArrayReader.ReadByte(i);
            OBJL = ArrayReader.ReadUShort(i);
            RVER = ArrayReader.ReadUShort(i);
            RUIN = (RUIN)ArrayReader.ReadByte(i);
        }
        public RCNM RCNM { get; set; }
        public uint RCID { get; set; }
        public byte PRIM { get; set; }
        public byte GRUP { get; set; }
        public ushort OBJL { get; set; }
        public ushort RVER { get; set; }
        public RUIN RUIN { get; set; }

        public FOID FOID { get; set; }
        public List<ATTF> ATTFS { get; set; }
        public List<NATF> NATFS { get; set; }
        public FFPC FFPC { get; set; }
        public List<FFPT> FFPTS { get; set; }
        public FSPC FSPC { get; set; }
        public List<FSPT> FSPTS { get; set; }
    }
}
