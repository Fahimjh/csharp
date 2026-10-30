using System;

class Program
{
    public static void Swap(ref int num1, ref int num2)
    {
        int temp=num1;
        num1=num2;
        num2=temp;
    }


    public static void Main(string[] args)
    {
        int num1,num2;
        Console.WriteLine("Enter two numbers: ");
        num1=Convert.ToInt32(Console.ReadLine());
        num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swap num1: {num1}, num2: {num2} ");
        Swap(ref num1, ref num2);
        Console.WriteLine($"After swap num1: {num1}, num2: {num2} ");
    }
}