using System;

public class EmpWageBuilderObject
{
	public const int is_part_time = 1;
	public const int is_full_time = 2;
	private string company;
	private int empRatePerHour;
	private int maxHoursPerMonth;
	private int numofWorkingDays;
	private int totalEmpwage;
	public EmpWageBuilderObject(strimg company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)

	{
		this.company = company;
		this.empRatePerHour = empRatePerHour;
		this.numofWorkingDays = numofWorkingDays;
		this.maxHourPerMonth = maxHoursPerMonth;

	}
	public void computeEmpWage()

}
int empHrs = 0, totalEmpHrs = 0, totalworingDays = 0;
while (totalEmpHrs <= this.maxHoursPerMonth && TotalWorkingDays < this.numofWorkingDays)
{
	totalWorkingDays++;
	Random random = new Random();
	int empCheck = random.Next(0, 3);
	switch (empCheck)
    {
		case is_part_time :
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
	Console.WriteLine("Day :" + totalWorkingDays + " Emp Hrs :" + empHrs);

		}
totalEmpWage = totalEmpHrs * this.empRatePerHour;
Console.WriteLine("Total Employee Wage for Company : " + company + "is:" + totalEmpWage);
}
public string tostring()
{
	return "total Emp Wage For Company :" + this.company + "is :" + this.totalEmpWage;
}
namespace EmpWageAndCompany
{
	class Program
	{
		static void Main(string[] args)
		{
			EmpWageBuilderObject Dmart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
			EmpWageBuilderObject reliance = new EmpWageBuilderObject("reliance", 10, 4, 20);
			Dmart.computeEmpWage();
			Console.WriteLine(Dmart.toString());
			Console.ReadKey();

			reliance.computeEmpWage();
			Console.WriteLine(reliance.toString());
			Console.ReadKey.();
			
		}
	}
}