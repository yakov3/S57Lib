using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public class LNAM
    {
        public LNAM(IEnumerator i)
        {
            AGEN = ArrayReader.ReadB12(i);
            FIDN = ArrayReader.ReadB14(i);
            FIDS = ArrayReader.ReadB12(i);
        }

        public uint AGEN { get; set; }
        public uint FIDN { get; set; }
        public uint FIDS { get; set; }
    }
}
