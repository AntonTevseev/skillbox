using System;
using static System.Console;
using System.Threading;

namespace xuy
{
    class Program
    {
       
        static void Main(string[]ages)
        {
            static void sss(string ss)
            {
                string[] Split = StringSplit(ss);
                string revers="";

                for(int i=Split.Length-1; i>=0;i--)
                {
                    revers=revers+Split[i]+" ";
                }
                WriteLine(revers);
            }
            
            static string[] StringSplit(string s)
            {
                
                string[] arr = s.Split(" ");
                return arr;
            }
            sss(ReadLine());

            
            
        }
    }
}
