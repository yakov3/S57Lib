using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public enum CURP
    {
        LL = 1,
        EN
    }
    public class DSRC
    {   
        public DSRC(IEnumerator i) 
        {
            RPID = ArrayReader.ReadByte(i);
            ArrayReader.PrintArr(i,8);
            //RYCO = ArrayReader.ReadB11(i);
            //RXCO = ArrayReader.ReadB11(i);
            //CURP = (CURP)ArrayReader.ReadB11(i);
            //FPMF = ArrayReader.ReadB14(i);
            //RXVL = ArrayReader.ReadB11(i);
            //RYVL = ArrayReader.ReadB11(i);
            //COMT = ArrayReader.ReadString(i);
        }
        public byte RPID { get; set; }
        public uint RYCO { get; set; }
        public uint RXCO { get; set; }
        public CURP CURP { get; set; }
        public uint FPMF { get; set; }
        public uint RXVL { get; set; }
        public uint RYVL { get; set; }
        public string COMT { get; set; }
    }
}
