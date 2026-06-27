using System;

class Program
{
    public static void Main(string[] args)
    {
        int num;

        Console.Write("Enter a number: ");
        num=Convert.ToInt32(Console.Read());
        Console.WriteLine("Your number: "+ num);

        Console.Write("Enter a number: ");
        num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your number: "+ num);

    }
}