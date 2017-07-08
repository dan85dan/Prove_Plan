using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = { 3.2, 3.5, 3.6 };
            foreach(double num in nums)
            {
                Console.WriteLine("{0} -> {1}", num, (int)num);
            }
            Console.ReadLine();

        }
    }
}
