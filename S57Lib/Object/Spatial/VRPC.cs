using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public enum VPUI
    {
        I = 1,
        D,
        M
    }
    public class VRPC
    {
        public VRPC(IEnumerator i) 
        {
            VPUI = (VPUI)ArrayReader.ReadByte(i);
            VPIX = ArrayReader.ReadUShort(i);
            NVPT = ArrayReader.ReadUShort(i);
        }
        public VPUI VPUI { get; set; }
        public ushort VPIX { get; set; }    
        public ushort NVPT { get; set; }
        public override string ToString()
        {
            return $"VPUI {VPUI} VPIX {VPIX} NVPT {NVPT}";
        }
    }
}
