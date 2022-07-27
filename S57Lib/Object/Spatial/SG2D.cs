using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public class SG2D
    {
        public SG2D(IEnumerator i) 
        {
            YCOO = ArrayReader.ReadLL(i);
            XCOO = ArrayReader.ReadLL(i);
        }
        public double YCOO { get; set; }
        public double XCOO { get; set; }
        public override string ToString()
        {
            return $"{YCOO} {XCOO}";
        }
    }
}
