using System;

class Program { 
static void Main(string[] args)
{
    student[] students = new student[5];
    students[0].firstName = "George";
    students[0].lastName = "Michael";
    students[0].birthDay = "01 Jan 2023";
    Console.WriteLine(students[0].firstName);
    Console.WriteLine(students[0].lastName);
    Console.WriteLine(students[0].birthDay);
        Console.ReadKey();
}

public struct student
{
    public string firstName;
    public string lastName;
    public string birthDay;
}

public struct teacher
{

}

public struct course
{

}
}