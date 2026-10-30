using System;

class Program
{
    public static void Main(string[] args)
    {        
        string name=" Fahim ";      
        Console.WriteLine("Before Trimmimng: "+name);        
        name=name.Trim();
        Console.WriteLine("After Trimmimng: "+name);        

        string subName1=name.Substring(2);
        Console.WriteLine(subName1);
        string subName2=name.Substring(1,3);
        Console.WriteLine(subName2);

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