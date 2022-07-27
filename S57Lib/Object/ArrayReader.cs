using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public class ArrayReader
    {
        public static uint COMF;
        public static uint SOMF;
        public static byte ReadByte(IEnumerator enumerator) 
        {
            enumerator.MoveNext();
            return (byte)enumerator.Current;
        }
        public static ushort ReadUShort(IEnumerator enumerator) 
        {
            byte[] arr = new byte[2];
            
            enumerator.MoveNext();
            arr[0] = (byte)enumerator.Current;
            enumerator.MoveNext();
            arr[1] = (byte)enumerator.Current;
            
            return BitConverter.ToUInt16(arr);
        }
        public static uint ReadUInt(IEnumerator enumerator)
        {
            byte[] arr = new byte[4];
            for (int i = 0; i < 4; i++) 
            {
                enumerator.MoveNext();
                arr[i] = (byte)enumerator.Current;
            }
            return BitConverter.ToUInt32(arr);
        }
        public static string ReadString(IEnumerator enumerator) 
        {
            string str = string.Empty;
            
            while(true)
            {
                enumerator.MoveNext();
                char c = Convert.ToChar(enumerator.Current);
                if (c == 0x1F) break;
                str += c;
            }
            return str;
        }
        public static ushort[] ReadStringL2(IEnumerator enumerator) 
        {
            List<ushort> list = new List<ushort>();
            while (true) 
            {
                byte[] arr = new byte[2];
                enumerator.MoveNext();
                arr[0] = (byte)enumerator.Current;
                enumerator.MoveNext();
                arr[1] = (byte)enumerator.Current;
                ushort i = BitConverter.ToUInt16(arr);
                if (i == 0x1F) break;
                list.Add(i);
            }
            return list.ToArray();
        }
        public static DateTime ReadDate(IEnumerator enumerator) 
        {
            string str = string.Empty;
            for (int i = 0; i < 8; i++) 
            {
                enumerator.MoveNext();
                char c = Convert.ToChar(enumerator.Current);
                str += c;
            }
            return DateTime.ParseExact(str,"yyyyMMdd", null);
        }
        public static double ReadReal(IEnumerator enumerator) 
        {
            string str = string.Empty;

            for (int i = 0; i < 4; i++)
            {
                enumerator.MoveNext();
                char c = Convert.ToChar(enumerator.Current);
                str += c;
            }
            return double.Parse(str.Replace('.', ','));
        }
        public static void PrintArr(IEnumerator enumerator, int length) 
        {
            for (int i = 0; i < length; i++) 
            {
                enumerator.MoveNext();
                Console.WriteLine(enumerator.Current);
            }
        }
        public static int ReadInt(IEnumerator enumerator) 
        {
            byte[] arr = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                enumerator.MoveNext();
                arr[i] = (byte)enumerator.Current;
            }
            return BitConverter.ToInt32(arr);
        }
        public static double ReadLL(IEnumerator enumerator) 
        {
            int i = ReadInt(enumerator);
            return (double)i/COMF;
        }
        public static double ReadH(IEnumerator enumerator) 
        {
            int i = ReadInt(enumerator);
            return (double)i/SOMF;
        }
    }
}
