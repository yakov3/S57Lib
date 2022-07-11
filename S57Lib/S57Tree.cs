using S57Lib.Object;
using S57Lib.Object.Feature;
using S57Lib.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace S57Lib
{
    public class S57Tree
    {
        public bool ReadFile(string fileName)
        {
            if (!File.Exists(fileName)) return false;
            using (FileStream fileStream = File.OpenRead(fileName))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    Ddr ddr = new Ddr();
                    if (!ddr.Read(binaryReader)) return false;

                    for (int i = 0; ; i++)
                    {
                        if (fileStream.Position == fileStream.Length) break;

                        Dr dr = new Dr();
                        if (!dr.Read(binaryReader)) return false;
                        foreach (KeyValuePair<string, byte[]> field in dr.fields)
                        {
                            switch (field.Key)
                            {
                                case "DSID":
                                    DSID = new DSID(field.Value);
                                    break;
                                case "DSSI":
                                    DSSI = new DSSI(field.Value);
                                    break;
                                case "DSPM":
                                    DSPM = new DSPM(field.Value);
                                    break;
                                case "DSRS":
                                    DSRC = new DSRC(field.Value);
                                    break;
                                case "FRID":
                                    FRID FRID = new FRID(field.Value);
                                    frids.Add(FRID);
                                    break;
                                case "FOID":
                                    FOID FOID = new FOID(field.Value);
                                    frids[^1].FOID = FOID;
                                    break;
                                case "ATTF":
                                    ATTF ATTF = new ATTF(field.Value);
                                    frids[^1].ATTFS.Add(ATTF);
                                    break;
                                case "NATF":
                                    NATF NAFT = new NATF(field.Value);
                                    frids[^1].NATFS.Add(NAFT);
                                    break;
                                case "FFPC":
                                    FFPC FFPC = new FFPC(field.Value);
                                    frids[^1].FFPC = FFPC;
                                    break;
                                case "FFPT":
                                    FFPT FFPT = new FFPT(field.Value);
                                    frids[^1].FFPTS.Add(FFPT);
                                    break;
                                case "FSPC":
                                    FSPC FSPC = new FSPC(field.Value);
                                    frids[^1].FSPC = FSPC;
                                    break;
                            }
                        }
                    }
                }
            }
            return true;
        }
        public DSID DSID { get; private set; }
        public DSSI DSSI { get; private set; }
        public DSPM DSPM { get; private set; }
        public DSRC DSRC { get; private set; }

        private List<FRID> frids = new List<FRID>();
        public List<FRID> FRIDS => frids;
    }
}
