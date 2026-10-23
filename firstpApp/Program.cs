using System;

class Program
{
    public static void Main(string[] args)
    {        
        int[,] arr= {
            {1,2,3},
            {4,5,6},
            {7,8,9},
            };
        foreach (int i in arr)
        {
            Console.Write($"{i} ");            
        }
    }
}
        
        
        
        
        
        
        
        // int a=5;
        
        // finally{
        //     Console.WriteLine("Finally block");
        // }
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

        // try
        // {
        //     Console.WriteLine("Enter a number: ");
        //     int num=Convert.ToInt32(Console.ReadLine());        
        //     Console.WriteLine("Your number: "+num);

        // }
        // catch (Exception obj)
        // {
        //     Console.WriteLine(obj.Message);

        // }
        // Console.WriteLine("End of Program");