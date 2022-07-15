using S57Lib;
using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Example\RU3HKEH0.000");

            S57Tree s57Tree = new S57Tree();
            bool result = s57Tree.ReadFile(fileName);
            Console.WriteLine(result);
        }
    }
}
