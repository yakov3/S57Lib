using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace S57Lib.Types.Directory
{
    public struct Entry 
    {
        public string tag;
        public int length;
        public int position;
    }
    public class Dir
    {
        public Dir(int tagFieldLength, int lengthFieldLength, int positionFieldLength) 
        {
            this.tagFieldLength = tagFieldLength;
            this.lengthFieldLength = lengthFieldLength;
            this.positionFieldLength = positionFieldLength;
        }
        public List<Entry> Entries 
        {
            get => entries;
        }
        public void Read(BinaryReader binaryReader) 
        {
            while (true) 
            {
                char tag0 = binaryReader.ReadChar();
                if (tag0 == 0x1E)
                {
                    return;
                }
                char[] tagArr = binaryReader.ReadChars(tagFieldLength - 1);
                string tag = tag0 + new string(tagArr);
                int length = Reader.ReadInt(binaryReader, lengthFieldLength);
                int position = Reader.ReadInt(binaryReader, positionFieldLength);
                entries.Add(new Entry
                {
                    tag = tag,
                    length = length,
                    position = position
                });
            }
        }
        private readonly List<Entry> entries = new List<Entry>();
        private readonly int tagFieldLength;
        private readonly int lengthFieldLength;
        private readonly int positionFieldLength;
    }
}
