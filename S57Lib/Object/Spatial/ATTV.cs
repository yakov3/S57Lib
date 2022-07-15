using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public class ATTV
    {
        public ATTV(IEnumerator i) 
        {
            ATTL = ArrayReader.ReadUShort(i);
            ATVL = ArrayReader.ReadString(i);    
        }
        public ushort ATTL { get; set; }
        public string ATVL { get; set; }
    }
}
