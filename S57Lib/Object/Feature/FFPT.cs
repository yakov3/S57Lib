using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{
    public enum RIND 
    {
        M = 1,
        S,
        P
    }
    public class FFPT
    {
        public FFPT(IEnumerator i) 
        {
            LNAM = new LNAM(i);
            RIND = (RIND)ArrayReader.ReadByte(i);
            COMT = ArrayReader.ReadString(i);
        }
        public LNAM LNAM { get; set; }
        public RIND RIND { get; set; }
        public string COMT { get; set; }
    }
}
