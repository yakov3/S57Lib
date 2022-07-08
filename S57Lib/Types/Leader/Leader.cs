using System.IO;

namespace S57Lib.Types.Leader
{
    public abstract class Leader
    {
        public int RecordLength { get; private set; }
        public char InterchangeLevel { get; private set; }
        public char LeaderIdentifier { get; private set; }
        public char InLineCodeExtensionIndicator { get; private set; }
        public char VersionNumber { get; private set; }
        public char ApplicationIndicator { get; private set; }
        public char[] FieldControlLength { get; private set; }
        public int BaseAddressOfFieldArea { get; private set; }
        public char[] ExtendedCharacterSetIndicator { get; private set; }
        public int SizeOfFieldLengthField { get; private set; }
        public int SizeOfFieldPositionField { get; private set; }
        public char Reserved { get; private set; }
        public int SizeOfFieldTagField { get; private set; }
        public bool Read(BinaryReader binaryReader) 
        {
            RecordLength = Reader.ReadInt(binaryReader, 5);
            InterchangeLevel = binaryReader.ReadChar();
            LeaderIdentifier = binaryReader.ReadChar();
            InLineCodeExtensionIndicator = binaryReader.ReadChar();
            VersionNumber = binaryReader.ReadChar();
            ApplicationIndicator = binaryReader.ReadChar();
            FieldControlLength = binaryReader.ReadChars(2);
            BaseAddressOfFieldArea = Reader.ReadInt(binaryReader, 5);
            ExtendedCharacterSetIndicator = binaryReader.ReadChars(3);
            SizeOfFieldLengthField = Reader.ReadInt(binaryReader, 1);
            SizeOfFieldPositionField = Reader.ReadInt(binaryReader, 1);
            Reserved = binaryReader.ReadChar();
            SizeOfFieldTagField = Reader.ReadInt(binaryReader, 1);
            return Check();
        }
        private bool Check() 
        {
            return PartCheak() &&
                RecordLength > 0 &&
                BaseAddressOfFieldArea > 0 &&
                SizeOfFieldLengthField > 0 &&
                SizeOfFieldPositionField > 0 &&
                Reserved == '0' &&
                SizeOfFieldTagField > 0;
        }
        abstract protected bool PartCheak();
    }
}
