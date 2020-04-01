using System;

class Employee
{
    public string attendanceCheck()
    {
        Random random = new Random();
        int attendanceRandom = random.Next(2);
        if(attendanceRandom==1)
        {
            return "Emp Present";
        }
        else
        {
            return "Emp Absent";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        String checkAttendance;
        Console.WriteLine("Welcome to Employee Wage Program!");
        Employee e1 = new Employee();
        checkAttendance=e1.attendanceCheck();
        Console.WriteLine(checkAttendance);
        }
    }
