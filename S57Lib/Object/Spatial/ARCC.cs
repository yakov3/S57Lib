using System.Collections;
using System.Collections.Generic;

namespace S57Lib.Object.Spatial
{
    public enum ATYP 
    {
        C = 1,
        E,
        U,
        B,
        N
    }
    public enum SURF 
    {
        E = 1,
        P
    }
    public class ARCC
    {
        public ARCC(IEnumerator i) 
        {
            ATYP = (ATYP)ArrayReader.ReadByte(i);
            SURF = (SURF)ArrayReader.ReadByte(i);
            ORDR = ArrayReader.ReadByte(i);
            RESO = ArrayReader.ReadUInt(i);
            FPMF = ArrayReader.ReadUInt(i);
        }
        public ATYP ATYP { get; set; }
        public SURF SURF { get; set; }
        public byte ORDR { get; set; }
        public uint RESO { get; set; }
        public uint FPMF { get; set; }
        public List<AR2D> AR2DS { get; set; }
        public List<EL2D> EL2DS { get; set; }
        public List<CT2D> CT2DS { get; set; }
    }
}
