using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace S57Lib.Types.Field.Descriptive
{
    public class ArrayDescriptor
    {
        public string[] Subfields => subfields;
        public string TypeStr => typesStr;
        public bool Read(BinaryReader binaryReader)
        {
            if (!ReadSubfields(binaryReader)) return false;
            if (!ReadTypes(binaryReader)) return false;
            return true;
        }
        private bool ReadSubfields(BinaryReader binaryReader)
        {
            string str = Reader.ReadString(binaryReader);
            subfields = str.Split('!');
            return subfields.Length > 0;
        }
        private bool ReadTypes(BinaryReader binaryReader)
        {
            typesStr = Reader.ReadStringFt(binaryReader);
            return true;
        }
        private string[] subfields;
        private string[] types;
        private string typesStr;
    }
}
