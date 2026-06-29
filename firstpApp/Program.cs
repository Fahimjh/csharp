using System;

class Program
{
    public static void Main(string[] args)
    {
        // int num;
        // char ch;
        // Console.Write("Enter a number: ");
        // ch = (char)Console.Read();
        // Console.WriteLine("Your number: " + ch);

        // Console.Write("Enter a number: ");
        // Console.ReadLine();
        // num = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Your number: " + num);

        // Console.Write("Press a key: ");
        // ConsoleKeyInfo key = Console.ReadKey();

        // Console.WriteLine();
        // Console.WriteLine($"You pressed: {key.KeyChar}");

        try
        {
            Console.WriteLine("Enter a number: ");
            int num=Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine("Your number: "+num);

        }
        catch (FormatException)
        {
            Console.WriteLine("Input thik koira dew");

        }
        Console.WriteLine("End of Program");
    }
}