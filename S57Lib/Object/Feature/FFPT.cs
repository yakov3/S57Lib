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
        public FFPT(byte[] arr) 
        {
            IEnumerator i = arr.GetEnumerator();
            LNAM = new LNAM(i);
            RIND = (RIND)ArrayReader.ReadB11(i);
            COMT = ArrayReader.ReadString(i);
        }
        public LNAM LNAM { get; set; }
        public RIND RIND { get; set; }
        public string COMT { get; set; }
    }
}
