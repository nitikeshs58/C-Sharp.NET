using System;

class Employee
{
    //constants
    int WAGE_PER_HOUR = 20;
    int FULLDAY_HOUR = 8;
    int PARTTIME_HOUR = 4;
    int ABSENTDAY_HOUR = 0;
    int MONTHLY_DAY = 20;

    //Variables
    int totalWagePerDay = 0;
    int day = 0;
    int workingHours = 0;
    int workHours = 0;

    public int totalWorkingHours(int hours)
    {
        workHours += hours;
        return workHours;
    }

    public int attendanceCheck()
    {
        while (day < MONTHLY_DAY && workingHours<=100)
        {
            day += 1;
            Random random = new Random();
            int attendanceRandom = random.Next(3);

            switch (attendanceRandom)
            {
                case 1:
                    totalWagePerDay = totalWagePerDay + WAGE_PER_HOUR * FULLDAY_HOUR;
                    workingHours = totalWorkingHours(FULLDAY_HOUR);
                    break;
                case 2:
                    totalWagePerDay = totalWagePerDay + WAGE_PER_HOUR * PARTTIME_HOUR;
                    workingHours = totalWorkingHours(PARTTIME_HOUR);
                    break;
                case 0:
                    totalWagePerDay = totalWagePerDay + WAGE_PER_HOUR * ABSENTDAY_HOUR;
                    workingHours = totalWorkingHours(ABSENTDAY_HOUR);
                    break;
            }
        }
        Console.WriteLine("total Working Hours: " + workingHours);
        return totalWagePerDay;
       }
}


class Program
{
    static void Main(string[] args)
    {
        int monthlyWage;
        Console.WriteLine("Welcome to Employee Wage Program!");
        Employee e1 = new Employee();
        monthlyWage=e1.attendanceCheck();
        Console.WriteLine("Monthly wage of emp: " + monthlyWage);
    }
}
