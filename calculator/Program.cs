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
            Calculator objCalculator = new Calculator();
            Console.WriteLine("total Values =" + objCalculator.isMul(30, 20));
            Console.ReadKey();
        }
    }
}
