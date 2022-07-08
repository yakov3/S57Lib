using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public class ArrayReader
    {
        public static uint ReadB11(IEnumerator enumerator) 
        {
            byte[] arr = new byte[4];

            enumerator.MoveNext();
            arr[0] = (byte)enumerator.Current;
            
            for(int i = 1; i < 4; i++) 
            {
                arr[i] = 0x00;
            }
            return BitConverter.ToUInt32(arr);
        }
        public static uint ReadB12(IEnumerator enumerator) 
        {
            byte[] arr = new byte[4];
            
            enumerator.MoveNext();
            arr[0] = (byte)enumerator.Current;
            enumerator.MoveNext();
            arr[1] = (byte)enumerator.Current;
            
            for (int i = 2; i < 4; i++)
            {
                arr[i] = 0x00;
            }
            return BitConverter.ToUInt32(arr);
        }
        public static uint ReadB14(IEnumerator enumerator)
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
    }
}
