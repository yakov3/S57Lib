using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace S57Lib.Types
{
    public class Reader
    {
        public static uint AALL;
        public static uint NALL;
        public static int ReadInt(BinaryReader binaryReader, int size)
        {
            char[] arr = binaryReader.ReadChars(size);
            return Int32.Parse(new string(arr));
        }
        public static string ReadString(BinaryReader binaryReader)
        {
            string str = String.Empty;
            char c;
            while (true)
            {
                c = binaryReader.ReadChar();
                if (c == 0x1F) break;
                str += c;
            }
            return str;
        }
        public static string ReadStringFt(BinaryReader binaryReader)
        {
            string str = String.Empty;
            char c;
            while (true)
            {
                c = binaryReader.ReadChar();
                if (c == 0x1E) break;
                str += c;
            }
            return str;
        }
        public static byte[] ReadByteArrayFt(BinaryReader binaryReader) 
        {
            Queue<byte> q = new Queue<byte>();
            while (true)
            {
                byte c = binaryReader.ReadByte();
                if (c == 0x1E) break;
                q.Enqueue(c);
            }
            if (q.Count == 0) return null;
            else 
            {
                byte[] arr = new byte[q.Count];
                for (int i = 0; i < q.Count; i++) arr[i] = q.Dequeue();
                return arr;
            }
        }
        public static byte[] ReadByteArr(BinaryReader binaryReader, int length) 
        {
            byte[] array = binaryReader.ReadBytes(length - 1);
            byte b = binaryReader.ReadByte();
            if (b != 0x1E)
            {
                return null;
            }
            else return array; 
        }
        public static byte[] ReadByteArrL2(BinaryReader binaryReader, int length) 
        {
            byte[] array = binaryReader.ReadBytes(length - 2);
            byte b0 = binaryReader.ReadByte();
            byte b1 = binaryReader.ReadByte();
            if (b0 == 0x1E && b1 == 0x00) return array;
            else return null;
        }
    }
}
