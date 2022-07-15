using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{
    public enum FSUI 
    {
        I = 1,
        D,
        M
    }
    public class FSPC
    {
        public FSPC(IEnumerator i) 
        {
            FSUI = (FSUI)ArrayReader.ReadByte(i);
            FSIX = ArrayReader.ReadUShort(i);
            NSPT = ArrayReader.ReadUShort(i);
        }
        public FSUI FSUI { get; set; }
        public uint FSIX { get; set; }
        public uint NSPT { get; set; }
    }
}
