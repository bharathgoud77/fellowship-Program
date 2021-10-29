using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            int Is_On_Leave = 2;
            int Emp_Rate_Per_Hour = 10;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee Is Present");
                empHrs = 8;

            }

            else
            {
                Console.WriteLine("Employee Is Absent");
                empHrs = 0;
                

            }
             if (empCheck == Is_On_Leave)
            {
                Console.WriteLine("Employee Is On Leave");
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("empWage"+ empWage);
            Console.ReadLine();

        }
    }
}
