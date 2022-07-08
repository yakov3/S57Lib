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
        public DSID(Byte[] arr) 
        {
            IEnumerator i = arr.GetEnumerator();
            RCNM = ArrayReader.ReadB11(i);           
            RCID = ArrayReader.ReadB14(i);
            EXPP = (EXPP)ArrayReader.ReadB11(i);
            INTU = ArrayReader.ReadB11(i);
            DSNM = ArrayReader.ReadString(i); 
            EDTN = ArrayReader.ReadString(i); 
            UPDN = ArrayReader.ReadString(i);
            UADT = ArrayReader.ReadDate(i);
            ISDT = ArrayReader.ReadDate(i);
            STED = ArrayReader.ReadReal(i);   
            PRSP = (PRSP)ArrayReader.ReadB11(i);
            PSDN = ArrayReader.ReadString(i);
            PRED = ArrayReader.ReadString(i);
            PROF = (PROF)ArrayReader.ReadB11(i);
            AGEN = ArrayReader.ReadB12(i);
            COMT = ArrayReader.ReadString(i);
        }
        public uint RCNM { get; set; }
        public uint RCID { get; set; }
        public EXPP EXPP { get; set; }
        public uint INTU { get; set; }
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
        public uint AGEN { get; set; }
        public string COMT { get; set; }
    }
}
