using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{   
    public class FFPC
    {
        public FFPC(byte[] arr)
        {
            IEnumerator i = arr.GetEnumerator();
            FFUI = (FFUI)ArrayReader.ReadB11(i);
            FFIX = ArrayReader.ReadB12(i);
            NFPT = ArrayReader.ReadB12(i);
        }
        public FFUI FFUI { get; set; }
        public uint FFIX { get; set; }
        public uint NFPT { get; set; }
    }
}
