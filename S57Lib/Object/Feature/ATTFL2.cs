using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{
    public class ATTFL2
    {
        public ATTFL2(IEnumerator i)
        {
            ATTL = ArrayReader.ReadUShort(i);
            ATVL = ArrayReader.ReadStringL2(i);
        }
        public ushort ATTL { get; set; }
        public ushort[] ATVL { get; set; }
    }
}
