using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public enum CCUI 
    {
        I = 1,
        D,
        M
    }
    public class SGCC
    {
        public SGCC(IEnumerator i) 
        {
            CCUI = (CCUI)ArrayReader.ReadByte(i);
            CCIX = ArrayReader.ReadUShort(i);
            CCNC = ArrayReader.ReadUShort(i);
        }
        public CCUI CCUI { get; set; }
        public ushort CCIX { get; set; }
        public ushort CCNC { get; set; }
    }
}
