using System;
using static System.Console;
using System.Threading;
namespace xuy
{
    class Program
    {
        static void Split()
        {
            string s = ReadLine();
            string[] split = s.Split(" ");
            foreach (var splits in split)
            {
                WriteLine(splits);
            }

        }
        static void Main(string[] ages)
        {
            Split();
        }
    }
}

