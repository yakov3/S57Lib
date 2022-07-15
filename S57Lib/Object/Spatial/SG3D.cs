using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public class SG3D : SG2D
    {
        public SG3D(IEnumerator i) : base(i) 
        {
            VE3D = ArrayReader.ReadH(i);
        }
        public double VE3D { get; set; }
    }
    
}
