using System;

class Employee
{
    //constants
    int WAGE_PER_HOUR = 20;
    int FULLDAY_HOUR = 8;
    int PARTTIME_HOUR = 4;
    int ABSENTDAY_HOUR = 0;

    //Variables
    int wagePerDay = 0;

    public void attendanceCheck()
    {
        Random random = new Random();
        int attendanceRandom = random.Next(3);

        switch (attendanceRandom)
        {
            case 1:
                wagePerDay = WAGE_PER_HOUR * FULLDAY_HOUR;
                Console.WriteLine(wagePerDay);
                break;
            case 2:
                wagePerDay = WAGE_PER_HOUR * PARTTIME_HOUR;
                Console.WriteLine(wagePerDay);
                break;
            case 0:
                wagePerDay = WAGE_PER_HOUR * ABSENTDAY_HOUR;
                Console.WriteLine(wagePerDay);
                break;
            default:
                Console.WriteLine("Invalid Entry.");
                break;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Wage Program!");
        Employee e1 = new Employee();
        e1.attendanceCheck();
    }
}
