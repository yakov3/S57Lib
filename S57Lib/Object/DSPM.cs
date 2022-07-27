using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public enum COUN 
    {
        LL = 1,
        EN,
        UC
    }
    public class DSPM
    {
        public DSPM(IEnumerator i)
        {
            RCNM = (RCNM)ArrayReader.ReadByte(i);
            RCID = ArrayReader.ReadUInt(i);
            HDAT = ArrayReader.ReadByte(i);
            VDAT = ArrayReader.ReadByte(i);
            SDAT = ArrayReader.ReadByte(i);
            CSCL = ArrayReader.ReadUInt(i);
            DUNI = ArrayReader.ReadByte(i);
            HUNI = ArrayReader.ReadByte(i);
            PUNI = ArrayReader.ReadByte(i);
            COUN = (COUN)ArrayReader.ReadByte(i);
            COMF = ArrayReader.ReadUInt(i);
            ArrayReader.COMF = COMF;
            SOMF = ArrayReader.ReadUInt(i);
            ArrayReader.SOMF = SOMF;
            COMT = ArrayReader.ReadString(i);
        }
        public RCNM RCNM { get; set; }
        public uint RCID { get; set; }
        public byte HDAT { get; set; }
        public byte VDAT { get; set; }
        public byte SDAT { get; set; }
        public uint CSCL { get; set; }
        public byte DUNI { get; set; }
        public byte HUNI { get; set; }
        public byte PUNI { get; set; }
        public COUN COUN { get; set; }
        public uint COMF { get; set; }
        public uint SOMF { get; set; }
        public string COMT { get; set; }
        public override string ToString()
        {
            return $"RCNM {RCNM}\n" +
                $"RCID {RCID}\n" +
                $"HDAT {HDAT}\n" +
                $"VDAT {VDAT}\n" +
                $"SDAT {SDAT}\n" +
                $"CSCL {CSCL}\n" +
                $"DUNI {DUNI}\n" +
                $"HUNI {HUNI}\n" +
                $"PUNI {PUNI}\n" +
                $"COUN {COUN}\n" +
                $"COMF {COMF}\n" +
                $"SOMF {SOMF}\n" +
                $"COMT {COMT}";
        }
    }
}
