using System;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Types.Leader
{
    public class DdrLeader : Leader
    {
        protected override bool PartCheak()
        {
            return InterchangeLevel == '3' &&
                LeaderIdentifier == 'L' &&
                InLineCodeExtensionIndicator == 'E' &&
                VersionNumber == '1' &&
                ApplicationIndicator == ' ' &&
                new string (FieldControlLength) == "09" &&
                new string (ExtendedCharacterSetIndicator) == " ! ";
        }
    }
}
