using System;
using static System.Console;
using System.Threading;
namespace xuy
{
    class Program
    {
        static void app(string N,string A)
        {
            string temp = N;
            N = A;
            A = temp;
            Write($"{N} {A}");
        }
        static void Main(string[]ages)
        {
            string N = ReadLine();  
            string A = ReadLine();
            app(N,A);    
        }
    }
}
