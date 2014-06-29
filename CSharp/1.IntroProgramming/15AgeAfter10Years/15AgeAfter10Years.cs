using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int birt = int.Parse(Console.ReadLine());
        Console.WriteLine("You will be {0} after 10 years", birt + 10);
    }
}

