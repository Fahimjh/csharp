using System;

class Program
{
    public static double Swap(ref int num1, ref int num2, out int add, out int sub, out int mul, out double div)
    {
        add = num1+num2;
        sub = num1-num2;
        mul = num1*num2;
        div = (double)num1/num2;
        double rem = (double)num1%num2;
        
        int temp=num1;
        num1=num2;
        num2=temp;

        
        return rem;
    }


    public static void Main(string[] args)
    {
        int num1,num2,add, sub, mul;
        double div, rem;
        Console.WriteLine("Enter two numbers: ");
        num1=Convert.ToInt32(Console.ReadLine());
        num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swap num1: {num1}, num2: {num2} ");
        rem= Swap(ref num1, ref num2, out add, out sub, out mul, out div);
        Console.WriteLine($"After swap num1: {num1}, num2: {num2} ");        
        Console.WriteLine($"Using out keywords: add: {add}, sub: {sub}, mul: {mul}, div: {div}, rem: {rem} ");
        Console.WriteLine(5%3);
    }
}