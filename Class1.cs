using System;
namespace DeclaringConstants
{
    class Program2
{
    static void Main(string[] args)
    {
        const float pi = 3.14159f;

            // constant declaration 
            float r;
        Console.WriteLine("Enter Radius: ");
        r = Convert.ToSingle(Console.ReadLine());
            float areaCircle = pi * r * r;
        Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
        Console.ReadLine();
    }
}
}