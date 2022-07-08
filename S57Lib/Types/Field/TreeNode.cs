using System;
using System.Collections.Generic;
using System.Text;

namespace S57Lib.Types.Field
{
    public class TreeNode<T>
    {
        public T Value;
        public List<T> Childs = new List<T>(); 
    }
}
