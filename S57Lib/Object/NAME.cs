using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public class NAME
    {
        public NAME(IEnumerator i) 
        {
            RCNM = (RCNM)ArrayReader.ReadByte(i);
            RCID = ArrayReader.ReadUInt(i);
        }
        public RCNM RCNM { get; set; } 
        public uint RCID { get; set; }
        public override string ToString()
        {
            return $"RCNM {RCNM} RCID {RCID}";
        }
    }
}
