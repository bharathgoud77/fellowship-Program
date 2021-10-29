using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empParttime
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_full_time=1;
            int is_part_time = 2;
            int emp_rate_per_hour = 10;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == is_full_time)
            {
                Console.WriteLine("emp[loyee present full time");
                empHrs = 8;
            }
            else if (empCheck == is_part_time)
            {
                Console.WriteLine("emplotyee present part time ");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("employee is absent");
                empHrs = 0;

            }
            empWage = empHrs * emp_rate_per_hour;
            Console.WriteLine("Employee Wage = " + empWage);
            Console.ReadLine();
            
        }
    }
}
