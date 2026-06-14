using System;

class Program
{
    public static void Main(string[] args)
    {
        string studentName;
        int studentAge;
        float cgpa;
        bool isReg;

        Console.WriteLine("Enter Student's Name: ");
        studentName= Console.ReadLine();
        Console.WriteLine("Enter Student's Age: ");
        studentAge= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student's CGPA: ");
        cgpa= float.Parse(Console.ReadLine());
        Console.WriteLine("If Student is Registered: ");
        isReg= Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Student's Name: "+studentName);
        Console.WriteLine("Student's Age: "+studentAge);
        Console.WriteLine("Student's cgpa: "+cgpa);
        Console.WriteLine("Student registered: "+isReg);
        
    }

}