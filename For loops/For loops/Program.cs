using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 15;
            int[] num = new int[] {3,14,15,92,6};
            string str = "The quick brown fox jumps over the lazy dog";
            //for(int i = 0; i < val; i++)
            //{
            //    Console.WriteLine("i is currently {0}",i);
            //}
            //foreach(int i in num)
            //{
            //    Console.WriteLine("i is currently {0}", i);
            //}

            var count = 0;
            foreach (char c in str) {
                if(c == 'o') { 
                    count++;
                }
            }
            Console.WriteLine("Counted{0} o characters",count);
            Console.ReadLine();
        }
    }
}
