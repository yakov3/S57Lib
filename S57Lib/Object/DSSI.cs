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
        public DSSI(Byte[] arr) 
        {
            IEnumerator i = arr.GetEnumerator();
            DSTR = (DSTR)ArrayReader.ReadB11(i);
            AALL = ArrayReader.ReadB11(i);
            NALL = ArrayReader.ReadB11(i);
            NOMR = ArrayReader.ReadB14(i);
            NOCR = ArrayReader.ReadB14(i);
            NOGR = ArrayReader.ReadB14(i);
            NOLR = ArrayReader.ReadB14(i);
            NOIN = ArrayReader.ReadB14(i);
            NOCN = ArrayReader.ReadB14(i);
            NOED = ArrayReader.ReadB14(i);
            NOFA = ArrayReader.ReadB14(i);
        }
        public DSTR DSTR { get; set; }
        public uint AALL { get; set; }
        public uint NALL { get; set; }
        public uint NOMR { get; set; }
        public uint NOCR { get; set; }
        public uint NOGR { get; set; }
        public uint NOLR { get; set; }
        public uint NOIN { get; set; }
        public uint NOCN { get; set; }
        public uint NOED { get; set; }
        public uint NOFA { get; set; }
    }
}
