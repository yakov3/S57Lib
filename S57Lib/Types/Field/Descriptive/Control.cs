using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace S57Lib.Types.Field.Descriptive
{
    public enum DataStructureCode
    {
        Linear = 1,
        MultiDimensional = 2
    };
    public enum DataTypeCode
    {
        String,
        Integer,
        Binary = 5,
        Mixed = 6
    };
    public class Control
    {
        public DataStructureCode DataStructureCode { get; private set; }
        public DataTypeCode DataTypeCode { get; private set; }
        public string AuxiliaryControls { get; private set; }
        public string PrintableGraphics { get; private set; }
        public int LexicalLevel { get; private set; }
        public bool Read(BinaryReader binaryReader)
        {
            DataStructureCode = (DataStructureCode)Reader.ReadInt(binaryReader, 1);
            DataTypeCode = (DataTypeCode)Reader.ReadInt(binaryReader, 1);

            AuxiliaryControls = new string(binaryReader.ReadChars(2));
            if (AuxiliaryControls != "00") return false;

            PrintableGraphics = new string(binaryReader.ReadChars(2));
            if (PrintableGraphics != ";&") return false;

            string str = new string(binaryReader.ReadChars(3));
            switch (str)
            {
                case "   ":
                    LexicalLevel = 0;
                    break;
                case "-A ":
                    LexicalLevel = 1;
                    break;
                case "%/A":
                    LexicalLevel = 2;
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
