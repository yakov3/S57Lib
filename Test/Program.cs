using S57Lib;
using S57Lib.Object;
using S57Lib.Object.Feature;
using S57Lib.Object.Spatial;
using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Example\RU3HKEH0.000");

            S57Tree s57Tree = new S57Tree();
            bool result = s57Tree.ReadFile(fileName);
            Console.WriteLine(result);

            if (s57Tree.FRIDS.Count < 578) return;
            FRID fRID = s57Tree.FRIDS[577];

            Console.WriteLine("DSID");
            Console.WriteLine(s57Tree.DSID);

            Console.WriteLine("-----\nDSSI");
            Console.WriteLine(s57Tree.DSSI);

            Console.WriteLine("-----\nDSPM");
            Console.WriteLine(s57Tree.DSPM);

            Console.WriteLine("-----\nDSRC");
            Console.WriteLine(s57Tree.DSRC);

            Console.WriteLine("-----\nFRID");
            Console.WriteLine(fRID);
            Console.WriteLine();

            foreach (VRID vRID in s57Tree.VRIDS) 
            {
                if (vRID.RCNM == RCNM.VI || vRID.RCID == 161) 
                {
                    Console.WriteLine("-----\nVRID");
                    Console.WriteLine(vRID);
                    break;
                }
            }
        }
    }
}
