using System;
using static System.Console;
using System.Threading;

namespace xuy
{
    class Program
    {
       
        static void Main(string[]ages)
        {
                
            static void app(string s)
            {
                
                string [] split = s.Split(' ');
                Array.Reverse(split);

                foreach(string s2 in split)
                {
                    Console.WriteLine(s2);
                }
            }
            string n = ReadLine();
            app(n);
            
        }
    }
}
