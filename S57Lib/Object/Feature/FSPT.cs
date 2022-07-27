using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Feature
{
    public enum USAG 
    {
        E = 1,
        I,
        C,
        N = 255
    }
    public class FSPT
    {
       
        public FSPT(IEnumerator i) 
        {
            NAME = new NAME(i);
            ORNT = (ORNT)ArrayReader.ReadByte(i);
            USAG = (USAG)ArrayReader.ReadByte(i);
            MASK = (MASK)ArrayReader.ReadByte(i);
        }
        public NAME NAME { get; set; }
        public ORNT ORNT { get; set; }
        public USAG USAG { get; set; }
        public MASK MASK { get; set; }
        public override string ToString()
        {
            return $"NAME | {NAME} | ORNT {ORNT} USAG {USAG} MASK {MASK}";
        }
    }
}
