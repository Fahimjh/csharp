using System;

class Person
{
    public string Name{get;set;}
    public int Age{get;set;}
}

class Program
{
    public static void Main(string[] args)
    {
        Person p1=new Person();
        Person p2=p1;
        p1.Name="Jamil Hasan Fahim";
        p1.Age=26;
        Console.WriteLine("P2 name: "+p2.Name);
        Console.WriteLine("P2 age: "+p2.Age);
    }
}