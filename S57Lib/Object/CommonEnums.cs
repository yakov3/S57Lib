using System;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public enum RCNM 
    {
        DS = 0x10,
        DP = 0x20,
        DH = 0x30,
        DA = 0x40,
        CR = 0x60,
        ID = 0x70,
        IO = 0x80,
        IS = 0x90,
        FE = 0x100,
        VI = 0x110,
        VC = 0x120,
        VE = 0x130,
        VF = 0x140
    }
    public enum RUIN
    {
        I = 1,
        D,
        M
    }
    public enum FFUI
    {
        I = 1,
        D,
        M
    }
    public enum MASK
    {
        M = 1,
        S,
        N = 255
    }
    public enum ORNT
    {
        F = 1,
        R,
        N = 255
    }
}
