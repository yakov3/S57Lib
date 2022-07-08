using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{
    public class ATTF
    {
        public ATTF(byte[] arr) 
        {
            IEnumerator i = arr.GetEnumerator();
            ATTL = ArrayReader.ReadB12(i);
            ATVL = ArrayReader.ReadString(i);
        }
        public uint ATTL { get; set; }
        public string ATVL { get; set; }
    }
}
