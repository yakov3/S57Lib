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
        public FSPC(byte[] arr) 
        {
            IEnumerator i = arr.GetEnumerator();
            FSUI = (FSUI)ArrayReader.ReadB11(i);
            FSIX = ArrayReader.ReadB12(i);
            NSPT = ArrayReader.ReadB12(i);
        }
        public FSUI FSUI { get; set; }
        public uint FSIX { get; set; }
        public uint NSPT { get; set; }
    }
}
