using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object.Spatial
{
    public class VRID
    {
        public VRID(IEnumerator i)
        {
            RCNM = (RCNM)ArrayReader.ReadByte(i);
            RCID = ArrayReader.ReadUInt(i);
            RVER = ArrayReader.ReadUShort(i);
            RUIN = (RUIN)ArrayReader.ReadByte(i);
        }
        public RCNM RCNM { get; set; }
        public uint RCID { get; set; }
        public ushort RVER { get; set; }
        public RUIN RUIN { get; set; }
        public List<ATTV> ATTVS { get; set; }
        public VRPC VRPC { get; set; }
        public List<VRPT> VRPTS { get; set; }
        public SGCC SGCC { get; set; }
        public List<SG2D> SG2DS { get; set; }
        public List<SG3D> SG3DS { get; set; }
        public List<ARCC> ARCCS { get; set; }
        public override string ToString()
        {
            string str = "VRID\n" +
                $"RCNM {RCNM}\n" +
                $"RCID {RCID}\n" +
                $"RVER {RVER}\n" +
                $"RUIN {RUIN}\n";
            if (ATTVS != null) 
            {
                str += $"ATTVS Count {ATTVS.Count}\n";
                foreach (ATTV aTTV in ATTVS) 
                {
                    str += $"   {aTTV}\n";
                }
            }
            if (VRPC != null) 
            {
                str += $"VRPC | {VRPC} |\n";
            }
            if (VRPTS != null) 
            {
                str += $"VRPTS Count {VRPTS.Count}\n";
                foreach (VRPT vRPT in VRPTS)
                {
                    str += $"   {vRPT}\n";
                }
            }
            if (SGCC != null) 
            {
                str += $"SGCC | {SGCC} |\n";
            }
            if (SG2DS != null) 
            {
                str += $"SG2DS Count {SG2DS.Count}\n    ";
                foreach (SG2D sG2D in SG2DS)
                {
                    str += $"{sG2D} | ";
                }
                str += '\n';
            }
            if (SG3DS != null)
            {
                str += $"SG3DS Count {SG3DS.Count}\n    ";
                foreach (SG3D sG3D in SG3DS)
                {
                    str += $"{sG3D} | ";
                }
                str += '\n';
            }
            return str;
        }
    }
}
