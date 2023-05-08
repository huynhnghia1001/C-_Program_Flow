using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_with_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theVal = 51;
            //if (theVal == 50)
            //{
            //    Console.WriteLine("TheVal is  50");
            //}
            //else if(theVal >=51 && theVal <= 60)
            //{
            //    Console.WriteLine("TheVal is between 51 and 60");
            //}
            //else
            //{
            //    Console.WriteLine("TheVal is something else");
            //}
            Console.WriteLine(theVal<50 ? "True" : "false");
            Console.ReadKey();
        }
    }
}
