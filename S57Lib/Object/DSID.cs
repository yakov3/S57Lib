using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public enum EXPP 
    {
        N = 1,
        R
    }
    public enum PRSP 
    {
        ENC = 1,
        ODD
    }
    public enum PROF 
    {
        EN = 1,
        ER,
        DD
    }
    public class DSID
    {
        public DSID(IEnumerator i) 
        {
            RCNM = (RCNM)ArrayReader.ReadByte(i);           
            RCID = ArrayReader.ReadUInt(i);
            EXPP = (EXPP)ArrayReader.ReadByte(i);
            INTU = ArrayReader.ReadByte(i);
            DSNM = ArrayReader.ReadString(i); 
            EDTN = ArrayReader.ReadString(i); 
            UPDN = ArrayReader.ReadString(i);
            UADT = ArrayReader.ReadDate(i);
            ISDT = ArrayReader.ReadDate(i);
            STED = ArrayReader.ReadReal(i);   
            PRSP = (PRSP)ArrayReader.ReadByte(i);
            PSDN = ArrayReader.ReadString(i);
            PRED = ArrayReader.ReadString(i);
            PROF = (PROF)ArrayReader.ReadByte(i);
            AGEN = ArrayReader.ReadUShort(i);
            COMT = ArrayReader.ReadString(i);
        }
        public RCNM RCNM { get; set; }
        public uint RCID { get; set; }
        public EXPP EXPP { get; set; }
        public byte INTU { get; set; }
        public string DSNM { get; set; }
        public string EDTN { get; set; }
        public string UPDN { get; set; }
        public DateTime UADT { get; set; }
        public DateTime ISDT { get; set; }
        public double STED { get; set; }
        public PRSP PRSP { get; set; }
        public string PSDN { get; set; }
        public string PRED { get; set; }
        public PROF PROF { get; set; }
        public ushort AGEN { get; set; }
        public string COMT { get; set; }
        public override string ToString()
        {
            return $"RCNM {RCNM}\n" +
                $"RCID {RCID}\n" +
                $"EXPP {EXPP}\n" +
                $"INTU {INTU}\n" +
                $"DSNM {DSNM}\n" +
                $"EDTN {EDTN}\n" +
                $"UPDN {UPDN}\n" +
                $"UADT {UADT}\n" +
                $"ISDT {ISDT}\n" +
                $"STED {STED}\n" +
                $"PRSP {PRSP}\n" +
                $"PSDN {PSDN}\n" +
                $"PRED {PRED}\n" +
                $"PROF {PROF}\n" +
                $"AGEN {AGEN}\n" +
                $"COMT {COMT}";
        }
    }
}
