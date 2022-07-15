using System.Collections;

namespace S57Lib.Object.Spatial
{
    public class EL2D
    {
        public EL2D(IEnumerator i) 
        {
            STPT = new SG2D(i);
            CTPT = new SG2D(i);
            ENPT = new SG2D(i);
            CDPM = new SG2D(i);
            CDPR = new SG2D(i);
        }
        public SG2D STPT { get; private set; }
        public SG2D CTPT { get; private set; }
        public SG2D ENPT { get; private set; }
        public SG2D CDPM { get; private set; }
        public SG2D CDPR { get; private set; }
    }
}
