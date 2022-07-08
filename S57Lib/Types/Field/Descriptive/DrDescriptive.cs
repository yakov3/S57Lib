using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace S57Lib.Types.Field.Descriptive
{
    public class DrDescriptive : IDescriptive
    {
        public byte[] Data1 => data;

        string IDescriptive.Data => throw new NotImplementedException();

        public bool Read(BinaryReader binaryReader)
        {
            data = Reader.ReadByteArrayFt(binaryReader);
            return true;
        }
        private byte[] data;
    }
}
