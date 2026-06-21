using System;

class person
{
    public string name;
    public int Age{get;set;}
}
class Program
{
    public static void Main(string[] args)
    {
       person p1= new person();
       p1.name="Jamil Hasan Fahim";
       Console.Write("Enter your age: ");
       p1.Age=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Your name: "+ p1.name);
       Console.WriteLine("Your age: "+p1.Age);

        
    }

}