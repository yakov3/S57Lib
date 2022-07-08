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
        public DSPM(Byte[] arr)
        {
            IEnumerator i = arr.GetEnumerator();
            RCNM = ArrayReader.ReadB11(i);
            RCID = ArrayReader.ReadB14(i);
            HDAT = ArrayReader.ReadB11(i);
            VDAT = ArrayReader.ReadB11(i);
            SDAT = ArrayReader.ReadB11(i);
            CSCL = ArrayReader.ReadB14(i);
            DUNI = ArrayReader.ReadB11(i);
            HUNI = ArrayReader.ReadB11(i);
            PUNI = ArrayReader.ReadB11(i);
            COUN = (COUN)ArrayReader.ReadB11(i);
            COMF = ArrayReader.ReadB14(i);
            SOMF = ArrayReader.ReadB14(i);
            COMT = ArrayReader.ReadString(i);
        }
        public uint RCNM { get; set; }
        public uint RCID { get; set; }
        public uint HDAT { get; set; }
        public uint VDAT { get; set; }
        public uint SDAT { get; set; }
        public uint CSCL { get; set; }
        public uint DUNI { get; set; }
        public uint HUNI { get; set; }
        public uint PUNI { get; set; }
        public COUN COUN { get; set; }
        public uint COMF { get; set; }
        public uint SOMF { get; set; }
        public string COMT { get; set; }
    }
}
