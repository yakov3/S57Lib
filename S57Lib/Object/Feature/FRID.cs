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
            PRIM = (PRIM)ArrayReader.ReadByte(i);
            GRUP = ArrayReader.ReadByte(i);
            OBJL = ArrayReader.ReadUShort(i);
            RVER = ArrayReader.ReadUShort(i);
            RUIN = (RUIN)ArrayReader.ReadByte(i);
        }
        public RCNM RCNM { get; set; }
        public uint RCID { get; set; }
        public PRIM PRIM { get; set; }
        public byte GRUP { get; set; }
        public ushort OBJL { get; set; }
        public ushort RVER { get; set; }
        public RUIN RUIN { get; set; }

        public FOID FOID { get; set; }
        public List<ATTF> ATTFS { get; set; }
        public List<ATTFL2> ATTFL2S { get; set; }
        public List<NATF> NATFS { get; set; }
        public List<NATFL2> NATFL2S { get; set; }
        public FFPC FFPC { get; set; }
        public List<FFPT> FFPTS { get; set; }
        public FSPC FSPC { get; set; }
        public List<FSPT> FSPTS { get; set; }

        public override string ToString()
        {
            string str = $"RCMN {RCNM}\n" +
                $"RCID {RCID}\n" +
                $"PRIM {PRIM}\n" +
                $"GRUP {GRUP}\n" +
                $"OBJL {OBJL}\n" +
                $"RVER {RVER}\n" +
                $"RUIN {RUIN}\n";
            if (FOID != null)
            {
                str += $"FOID {FOID}\n";
            }
            if (ATTFS != null)
            {
                str += $"ATTFS Count {ATTFS.Count}\n";
                foreach (ATTF aTTF in ATTFS)
                {
                    str += $"   ATTL {aTTF.ATTL} ATVL {aTTF.ATVL}\n";
                }
            }
            if (ATTFL2S != null)
            {
                str += $"ATTFL2S Count {ATTFL2S.Count}\n";
                foreach (ATTFL2 aTTFL2 in ATTFL2S)
                {
                    str += $"   ATTL {aTTFL2.ATTL} ATVL ";
                    foreach (ushort i in aTTFL2.ATVL)
                    {
                        str += $"{i} ";
                    }
                    str += '\n';
                }
            }
            if (NATFS != null)
            {
                str += $"NATFS Count {NATFS.Count}\n";
                foreach (NATF NATF in NATFS)
                {
                    str += $"   ATTL {NATF.ATTL} ATVL {NATF.ATVL}\n";
                }
            }
            if (NATFL2S != null)
            {
                str += $"NATFL2S Count {NATFL2S.Count}\n";
                foreach (NATFL2 NATFL2 in NATFL2S)
                {
                    str += $"   ATTL {NATFL2.ATTL} ATVL ";
                    foreach (ushort i in NATFL2.ATVL)
                    {
                        str += $"{i} ";
                    }
                    str += '\n';
                }
            }
            if (FFPC != null) 
            {
                str += $"FFPC {FFPC}";
            }
            if (FFPTS != null) 
            {
                str += $"FFPTS Count {FFPTS.Count}\n";
                foreach (FFPT fFPT in FFPTS) 
                {
                    str += $"   {fFPT}\n";
                }
            }
            if (FSPC != null) 
            {
                str += $"FSPC {FSPC}";
            }
            if (FSPTS != null) 
            {
                str += $"FSPTS Count {FSPTS.Count}\n";
                foreach (FSPT fSPT in FSPTS)
                {
                    str += $"   {fSPT}\n";
                }
            }
            return str;
        }
    }
}
