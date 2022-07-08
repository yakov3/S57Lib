using System;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Types.Leader
{
    public class DrLeader : Leader
    {
        protected override bool PartCheak()
        {
            return InterchangeLevel == ' ' &&
                LeaderIdentifier == 'D' &&
                InLineCodeExtensionIndicator == ' ' &&
                VersionNumber == ' ' &&
                ApplicationIndicator == ' ' &&
                new string(FieldControlLength) == "  " &&
                new string(ExtendedCharacterSetIndicator) == "   ";
        }
    }
}
