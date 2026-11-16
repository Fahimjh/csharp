using System;

class Program
{
    public static double Calculator(ref int num1, ref int num2, out int add, out int sub, out int div, out int mul)
    {
        double rem= (double)num1 % num2;
        add= num1+num2;
        sub= num1-num2;
        mul= num1*num2;
        div= num1/num2;
        int temp;
        temp= num1;
        num1= num2;
        num2= temp;

        return rem;
    }
    public static void Main(string[] args)
    {
        int num1, num2, add, sub, mul, div;
        double rem;
        Console.WriteLine("Enter two int numbers: ");
        num1=Convert.ToInt32(Console.ReadLine());
        num2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Before swap num1={num1}, num2={num2}");
        rem=Calculator(ref num1, ref num2, out add, out sub, out div, out mul);
        Console.WriteLine($"After swap num1={num1}, num2={num2}");
        Console.WriteLine($"Add={add}, Sub={sub}, Mul={mul}, Div= {div}, Rem={rem}");
    }
}    