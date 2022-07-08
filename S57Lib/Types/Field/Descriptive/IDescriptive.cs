using System.IO;

namespace S57Lib.Types.Field.Descriptive
{
    interface IDescriptive
    {
        bool Read(BinaryReader binaryReader);
        string Data { get; }
    }
}
