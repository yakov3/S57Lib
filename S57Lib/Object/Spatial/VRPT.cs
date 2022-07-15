using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public enum USAG 
    {
        E = 1,
        I,
        C,
        N
    }
    public enum TOPI 
    {
        B = 1,
        E,
        S,
        D,
        F,
        N
    }
    public class VRPT
    {
        public VRPT(IEnumerator i) 
        {
            NAME = new NAME(i);
            ORNT = (ORNT)ArrayReader.ReadByte(i);
            USAG = (USAG)ArrayReader.ReadByte(i);
            TOPI = (TOPI)ArrayReader.ReadByte(i);
            MASK = (MASK)ArrayReader.ReadByte(i);
        }
        public NAME NAME { get; set; }
        public ORNT ORNT { get; set; }
        public USAG USAG { get; set; }
        public TOPI TOPI { get; set; }
        public MASK MASK { get; set; }
    }
}
