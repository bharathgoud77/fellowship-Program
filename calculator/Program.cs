using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calulator objCalulator = new Calulator();
            Console.WriteLine("total Values =" + objCalulator.isSum(30, 20));
            Console.ReadKey();
        }
    }
}
