using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace S57Lib.Types.Field
{
    public class ControlField
    {
        public ControlField(int tagFieldLength) 
        {
            this.tagFieldLength = tagFieldLength;
        }
        public bool Read(BinaryReader binaryReader)
        {
            char[] arr = binaryReader.ReadChars(9);
            if (new string(arr) != "0000;&   ") return false;
            char c = binaryReader.ReadChar();
            if (c != 0x1F) return false;
            bool first = true;
            while (true)
            {
                char tag0 = binaryReader.ReadChar();
                if (tag0 == 0x1E) return true;
                char[] tagArr = binaryReader.ReadChars(tagFieldLength - 1);
                string tag = tag0 + new string(tagArr);
                if (first)
                {
                    tags.Add(tag);
                    first = false;
                }
                tagArr = binaryReader.ReadChars(tagFieldLength);
                string tag1 = new string(tagArr);
                tags.Add(tag1);
            }
        }
        private readonly int tagFieldLength;
        private List<string> tags = new List<string>();
    }
}
