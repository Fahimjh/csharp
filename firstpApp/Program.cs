using System;

class Program
{
    private string Name; //{get;set;}
    private int Age; //{get;set;}

    public static void Main(string[] args)
    {
        Program pr1= new Program();
        pr1.Name="Fahim";
        Console.WriteLine(pr1.Name);
    }
}