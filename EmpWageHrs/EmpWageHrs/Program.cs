using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageHrs
{
    class Program
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int emp_on_leave = 3;
        public const int emp_rate_per_hour = 20;
            public const int num_of_working_days = 20;
        public const int num_of_hours_in_month = 40;
        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0, empWage = 0;
            while (totalEmpHrs<= num_of_hours_in_month && totalworkingDays < num_of_working_days)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 4);
                switch (empCheck)
                {
                    case is_part_time:
                      
                        empHrs = 4;
                        break;
                    case is_full_time:
                        empHrs = 8;
                        break;
                    case emp_on_leave:
                        empHrs = 8;
                        break;
                        default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                empWage = empHrs * emp_rate_per_hour;
                Console.WriteLine("day :" + totalworkingDays + "emp Hrs :" + empHrs);
                Console.WriteLine("Employee Wage =" + empWage);



            }
            int totalWage = totalEmpHrs * emp_rate_per_hour;
            Console.WriteLine("total EmpWage :" + totalWage);
            Console.ReadLine();
        }
    }
}
