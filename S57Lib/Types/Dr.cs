using System;
using System.Collections.Generic;
using System.IO;
using S57Lib.Types.Field.Descriptive;
using S57Lib.Types.Leader;

namespace S57Lib.Types
{
    public class Dr : DataRecord
    {
        public DrLeader DrLeader = new DrLeader();
        protected override Leader.Leader Leader => DrLeader;
        public List<DrDescriptive> Descriptives => descriptives;
        protected override uint AALL => Reader.AALL;
        protected override uint NALL => Reader.NALL;

        private List<DrDescriptive> descriptives = new List<DrDescriptive>();
    }
}
