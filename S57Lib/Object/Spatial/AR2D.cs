using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public class AR2D
    {
        public AR2D(IEnumerator i)
        {
            STPT = new SG2D(i);
            CTPT = new SG2D(i);
            ENPT = new SG2D(i);
        }
        public SG2D STPT { get; private set; }
        public SG2D CTPT { get; private set; }
        public SG2D ENPT { get; private set; }
    }
}
