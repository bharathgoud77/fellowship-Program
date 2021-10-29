using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empcase
{
    class Program
    { 
        
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int emp_rate_per_hour = 20;
        static void Main(string[] args)
        {
           int empHrs = 0;
        int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case is_part_time:
                    empHrs = 4;
                    break;
                case is_full_time:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * emp_rate_per_hour;
            Console.WriteLine("Employee Wage = " + empWage);
            Console.ReadLine();

        }
    }
}
