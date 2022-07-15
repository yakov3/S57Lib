using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{   
    public class FFPC
    {
        public FFPC(IEnumerator i)
        {
            FFUI = (FFUI)ArrayReader.ReadByte(i);
            FFIX = ArrayReader.ReadUShort(i);
            NFPT = ArrayReader.ReadUShort(i);
        }
        public FFUI FFUI { get; set; }
        public ushort FFIX { get; set; }
        public ushort NFPT { get; set; }
    }
}
