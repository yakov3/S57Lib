using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Object
{
    public class ArrayIEnumerator : IEnumerator
    {
        public ArrayIEnumerator(Array array) 
        {
            i = array.GetEnumerator();
            length = array.Length;
        }
        public object Current => i.Current;

        public bool MoveNext()
        {
            bool result = i.MoveNext();
            if (result) pos += 1;
            return result;
        }

        public void Reset()
        {
            i.Reset();
            pos = -1;
        }
        public bool IsEnd => pos == length - 1;
        private readonly IEnumerator i;
        private readonly int length;
        private int pos = -1;
    }
}
