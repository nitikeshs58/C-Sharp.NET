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

    public int attendanceCheck()
    {
        Random random = new Random();
        int attendanceRandom = random.Next(3);

        if (attendanceRandom==1)
        {
            wagePerDay = WAGE_PER_HOUR * FULLDAY_HOUR;
            return wagePerDay;
        }
        else if(attendanceRandom==0)
        {
            wagePerDay = WAGE_PER_HOUR * PARTTIME_HOUR;
            return wagePerDay;
        }
        else
        {
            wagePerDay = WAGE_PER_HOUR * ABSENTDAY_HOUR;
            return wagePerDay;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int checkAttendance;
        Console.WriteLine("Welcome to Employee Wage Program!");
        Employee e1 = new Employee();
        checkAttendance=e1.attendanceCheck();
        Console.WriteLine(checkAttendance);
    }
}
