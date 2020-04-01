using System;
using System.Collections.Generic;

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
    int dailyWageFulltime = 0;
    int dailyWageParttime = 0;
    int dailyWageAbsent = 0;
    int day = 1;
    int workingHours = 0;
    int workHours = 0;

    Dictionary<int, int> EmpDailyWageKV = new Dictionary<int, int>();

    public int totalWorkingHours(int hours)
    {
        workHours += hours;
        return workHours;
    }

    public void dailyWageDict(int days,int dailyWage)
    {
        EmpDailyWageKV.Add(days, dailyWage);
    }

    public int attendanceCheck()
    {
        while (day <= MONTHLY_DAY && workingHours<=100)
        {
            Random random = new Random();
            int attendanceRandom = random.Next(3);

            switch (attendanceRandom)
            {
                case 1:
                    dailyWageFulltime = WAGE_PER_HOUR * FULLDAY_HOUR;
                    totalWagePerDay = totalWagePerDay + dailyWageFulltime;
                    dailyWageDict(day, dailyWageFulltime);
                    workingHours = totalWorkingHours(FULLDAY_HOUR);
                    break;
                case 2:
                    dailyWageParttime = WAGE_PER_HOUR * PARTTIME_HOUR;
                    totalWagePerDay = totalWagePerDay + dailyWageParttime;
                    dailyWageDict(day, dailyWageParttime);
                    workingHours = totalWorkingHours(PARTTIME_HOUR);
                    break;
                case 0:
                    dailyWageAbsent=WAGE_PER_HOUR * ABSENTDAY_HOUR;
                    totalWagePerDay = totalWagePerDay + dailyWageAbsent;
                    dailyWageDict(day, dailyWageAbsent);
                    workingHours = totalWorkingHours(ABSENTDAY_HOUR);
                    break;
            }
            day += 1;
        }
        Console.WriteLine("total Working Hours: " + workingHours);
        foreach(KeyValuePair<int,int> wage in EmpDailyWageKV)
        {
            Console.WriteLine("Day:{0}  wage: {1}", wage.Key, wage.Value);
        }
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
