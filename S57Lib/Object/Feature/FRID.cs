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
        public FRID(byte[] arr)
        {
            IEnumerator i = arr.GetEnumerator();
            RCNM = ArrayReader.ReadB11(i);
            RCID = ArrayReader.ReadB14(i);
            PRIM = ArrayReader.ReadB11(i);
            GRUP = ArrayReader.ReadB11(i);
            OBJL = ArrayReader.ReadB12(i);
            RVER = ArrayReader.ReadB12(i);
            RUIN = (RUIN)ArrayReader.ReadB11(i);
        }
        public uint RCNM { get; set; }
        public uint RCID { get; set; }
        public uint PRIM { get; set; }
        public uint GRUP { get; set; }
        public uint OBJL { get; set; }
        public uint RVER { get; set; }
        public RUIN RUIN { get; set; }
        public FOID FOID { get; set; }
        public FFPC FFPC { get; set; }
        public FSPC FSPC { get; set; }

        public List<ATTF> ATTFS = new List<ATTF>();
        public List<NATF> NATFS = new List<NATF>();
        public List<FFPT> FFPTS = new List<FFPT>();
    }
}
