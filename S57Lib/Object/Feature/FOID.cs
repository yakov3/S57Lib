using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{
    public class FOID
    {
        public FOID(IEnumerator i) 
        {
            AGEN = ArrayReader.ReadUShort(i);
            FIDN = ArrayReader.ReadUInt(i);
            FIDS = ArrayReader.ReadUShort(i);
        }
        public ushort AGEN { get; set; }
        public uint FIDN { get; set; }
        public ushort FIDS { get; set; }

        public override string ToString()
        {
            return $"AGEN {AGEN} FIDN {FIDN} FIDS {FIDS}";
        }
    }
}
