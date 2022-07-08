﻿using System;
using System.Collections.Generic;
using System.IO;
using S57Lib.Types.Directory;

namespace S57Lib.Types
{
    public abstract class DataRecord
    {
        protected abstract Leader.Leader Leader { get; }
        public Dir Dir = null;
        public Dictionary<string, byte[]> fields = new Dictionary<string, byte[]>();
        public bool Read(BinaryReader binaryReader)
        {
            if (!Leader.Read(binaryReader)) return false;

            Dir = new Dir(Leader.SizeOfFieldTagField, Leader.SizeOfFieldLengthField, Leader.SizeOfFieldPositionField);
            Dir.Read(binaryReader);
            if (Dir.Entries.Count == 0) return false;
            
            for (int i = 0; i < Dir.Entries.Count; i++)
            {
                byte[] arr = Reader.ReadByteArr(binaryReader, Dir.Entries[i].length);
                if (arr == null) return false;
                fields.Add(Dir.Entries[i].tag, arr);
            }
            return true;
        }
    }
}
