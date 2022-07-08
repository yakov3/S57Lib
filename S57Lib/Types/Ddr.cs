using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using S57Lib.Types.Field;
using S57Lib.Types.Leader;

namespace S57Lib.Types
{
    public class Ddr : DataRecord
    {
        public DdrLeader DdrLeader = new DdrLeader();
        protected override Leader.Leader Leader => DdrLeader;
        public List<Field.Descriptive.DdrDescriptive> Descriptives => descriptives;
        private List<Field.Descriptive.DdrDescriptive> descriptives = new List<Field.Descriptive.DdrDescriptive>();
        private ControlField controlField = new ControlField(4);
    }
}
