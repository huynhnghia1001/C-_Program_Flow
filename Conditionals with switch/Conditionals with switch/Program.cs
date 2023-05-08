using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_with_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theVal = 60;

            switch (theVal)
            {
                case 50:
                    Console.WriteLine("theVal is 50");
                    break;
                case 51:
                    Console.WriteLine("TheVal is 51");
                    break;
                case 52:
                case 53:
                case 54:
                    Console.WriteLine("TheVal is between 52 and 54");
                    break;
                default:
                    Console.WriteLine("TheVal is something else");
                    break;
            }
            Console.ReadLine();
        }
    }
}
