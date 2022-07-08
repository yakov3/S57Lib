using System;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public enum RCNM
    {
        VI,
        VC,
        VE,
        VF
    }
   
    public class VRID
    {
        public RCNM RCNM { get; set; }
        public int RCID { get; set; }
        public int RVER { get; set; }
        public RUIN RUIN { get; set; }
    }
}
