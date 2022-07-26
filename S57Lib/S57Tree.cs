using S57Lib.Object;
using S57Lib.Object.Feature;
using S57Lib.Object.Spatial;
using S57Lib.Types;
using System;
using System.Collections;
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

                    for (int x = 0; ; x++)
                    {
                        if (fileStream.Position == fileStream.Length) break;

                        Dr dr = new Dr();
                        if (!dr.Read(binaryReader)) return false;
                        foreach (KeyValuePair<string, byte[]> field in dr.fields)
                        {
                            ArrayIEnumerator i = new ArrayIEnumerator(field.Value);
                            switch (field.Key)
                            {
                                case "DSID":
                                    DSID = new DSID(i);
                                    break;
                                case "DSSI":
                                    DSSI = new DSSI(i);
                                    break;
                                case "DSPM":
                                    DSPM = new DSPM(i);
                                    break;
                                case "DSRS":
                                    DSRC = new DSRC(i);
                                    break;

                                #region FRID

                                case "FRID":
                                    FRID FRID = new FRID(i);
                                    frids.Add(FRID);
                                    break;
                                case "FOID":
                                    FOID FOID = new FOID(i);
                                    frids[^1].FOID = FOID;
                                    break;
                                case "ATTF":
                                    do
                                    {
                                        ATTF ATTF = new ATTF(i);
                                        if (frids[^1].ATTFS == null) frids[^1].ATTFS = new List<ATTF>();
                                        frids[^1].ATTFS.Add(ATTF);
                                    }
                                    while (!i.IsEnd);
                                    break;
                                case "NATF":
                                    //do
                                    //{
                                    //    NATF NAFT = new NATF(i);
                                    //    if (frids[^1].NATFS == null) frids[^1].NATFS = new List<NATF>();
                                    //    frids[^1].NATFS.Add(NAFT);
                                    //}
                                    //while (!i.IsEnd);
                                    break;
                                case "FFPC":
                                    FFPC FFPC = new FFPC(i);
                                    frids[^1].FFPC = FFPC;
                                    break;
                                case "FFPT":
                                    do
                                    {
                                        FFPT FFPT = new FFPT(i);
                                        if (frids[^1].FFPTS == null) frids[^1].FFPTS = new List<FFPT>();
                                        frids[^1].FFPTS.Add(FFPT);
                                    }
                                    while (!i.IsEnd);
                                    break;
                                case "FSPC":
                                    FSPC FSPC = new FSPC(i);
                                    frids[^1].FSPC = FSPC;
                                    break;
                                case "FSPT":
                                    do
                                    {
                                        FSPT FSPT = new FSPT(i);
                                        if (frids[^1].FSPTS == null) frids[^1].FSPTS = new List<FSPT>();
                                        frids[^1].FSPTS.Add(FSPT);
                                    }
                                    while (!i.IsEnd);
                                    break;

                                #endregion

                                #region VRID

                                case "VRID":
                                    vrids.Add(new VRID(i));
                                    break;

                                case "ATTV":
                                    do
                                    {
                                        ATTV ATTV = new ATTV(i);
                                        if (vrids[^1].ATTVS == null) vrids[^1].ATTVS = new List<ATTV>();
                                        vrids[^1].ATTVS.Add(ATTV);
                                    }
                                    while (!i.IsEnd);
                                    break;

                                case "VRPC":
                                    vrids[^1].VRPC = new VRPC(i);
                                    break;

                                case "VRPT":
                                    do
                                    {
                                        VRPT VRPT = new VRPT(i);

                                        if (vrids[^1].VRPTS == null) vrids[^1].VRPTS = new List<VRPT>();
                                        vrids[^1].VRPTS.Add(VRPT);
                                    }
                                    while (!i.IsEnd);
                                    break;

                                case "SGCC":
                                    vrids[^1].SGCC = new SGCC(i);
                                    break;

                                case "SG2D":
                                    do
                                    {
                                        SG2D SG2D = new SG2D(i);

                                        if (vrids[^1].SG2DS == null) vrids[^1].SG2DS = new List<SG2D>();
                                        vrids[^1].SG2DS.Add(SG2D);
                                    }
                                    while (!i.IsEnd);
                                    break;

                                case "SG3D":
                                    do
                                    {
                                        SG3D SG3D = new SG3D(i);

                                        if (vrids[^1].SG3DS == null) vrids[^1].SG3DS = new List<SG3D>();
                                        vrids[^1].SG3DS.Add(SG3D);
                                    }
                                    while (!i.IsEnd);
                                    break;

                                case "ARCC":
                                    do
                                    {
                                        ARCC ARCC = new ARCC(i);
                                        if (vrids[^1].ARCCS == null) vrids[^1].ARCCS = new List<ARCC>();
                                        vrids[^1].ARCCS.Add(ARCC);
                                        break;
                                    }
                                    while (!i.IsEnd);
                                    break;

                                case "AR2D":
                                    do
                                    {
                                        AR2D AR2D = new AR2D(i);
                                        if (vrids[^1].ARCCS[^1].AR2DS == null) vrids[^1].ARCCS[^1].AR2DS = new List<AR2D>();
                                        vrids[^1].ARCCS[^1].AR2DS.Add(AR2D);
                                    }
                                    while (!i.IsEnd);
                                    break;

                                case "EL2D":
                                    do
                                    {
                                        EL2D EL2D = new EL2D(i);
                                        if (vrids[^1].ARCCS[^1].EL2DS == null) vrids[^1].ARCCS[^1].EL2DS = new List<EL2D>();
                                        vrids[^1].ARCCS[^1].EL2DS.Add(EL2D);
                                    }
                                    while (!i.IsEnd);
                                    break;

                                case "CT2D":
                                    do
                                    {
                                        CT2D CT2D = new CT2D(i);
                                        if (vrids[^1].ARCCS[^1].CT2DS == null) vrids[^1].ARCCS[^1].CT2DS = new List<CT2D>();
                                        vrids[^1].ARCCS[^1].CT2DS.Add(CT2D);
                                    }
                                    while (!i.IsEnd);
                                    break;

                                    #endregion
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
        public List<FRID> FRIDS => frids;
        public List<VRID> VRIDS => vrids;
        
        private List<FRID> frids = new List<FRID>();
        private List<VRID> vrids = new List<VRID>();
    }
}
