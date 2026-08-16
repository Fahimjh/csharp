using System;

class Program
{
    public static void Main(string[] args)
    {
       Console.Write("Enter a num: ");
       int num=Convert.ToInt16(Console.ReadLine());
       Console.WriteLine("For Loop--->");
       for(int i=1; i<=num; i++)
       {
            for(int j=1; j<=i; j++)
            {
                Console.Write(j+" ");
            }
                Console.WriteLine();
        }

        Console.WriteLine("While Loop--->");
        int a=1;
        
        while(true)
        {            
                int j=1;
            while(true)
            {
                Console.Write(j+" ");
                j++;                
                if(j>a)
                    break;
            }
                Console.WriteLine();
                a++;
                if(a>num)
                    break;
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