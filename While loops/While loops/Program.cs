using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";
            //Console.WriteLine("Basic While() loop: ");
            //while (inputStr != "exit") {
            //    inputStr = Console.ReadLine();
            //    Console.WriteLine("You entered: {0}", inputStr);
            //}

            Console.WriteLine("The do-while() loop: ");
            do
            {
                inputStr = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputStr);
            } while (inputStr != "exit");
            Console.ReadKey();
        }
    }
}
