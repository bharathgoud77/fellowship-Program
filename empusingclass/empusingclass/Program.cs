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
        
        public const int emp_rate_per_hour = 20;
        public const int num_of_working_days = 20;
        public const int num_of_hours_in_month = 40;
        public static int computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0, EmpWage = 0;
            while (totalEmpHrs <= num_of_hours_in_month && totalworkingDays < num_of_working_days)
            {
                totalworkingDays++;
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
                totalEmpHrs += empHrs;
                EmpWage = empHrs * emp_rate_per_hour;
                Console.WriteLine("day :" + totalworkingDays + "emp Hrs :" + empHrs);
                Console.WriteLine("Employee Wage =" + EmpWage);



            }
            int totalEmpWage = totalEmpHrs * emp_rate_per_hour;
            Console.WriteLine("total EmpWage :" + totalEmpWage);
            Console.ReadLine();
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage();
        }
    }
}