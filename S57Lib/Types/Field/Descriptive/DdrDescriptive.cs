using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace S57Lib.Types.Field.Descriptive
{
    public class DdrDescriptive : IDescriptive
    {
        public string Name => name;
        public string Data => data;
        public ArrayDescriptor ArrayDescriptor => arrayDescriptor;
        public bool Read(BinaryReader binaryReader)
        {
            if (!control.Read(binaryReader)) return false;
            name = Reader.ReadString(binaryReader);
            if (!arrayDescriptor.Read(binaryReader)) return false;
            return true;
        }

        private string name;
        private string data;
        private Control control = new Control();
        private ArrayDescriptor arrayDescriptor = new ArrayDescriptor();
    }
}
