using System;

namespace Lab2RoomCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
        
                Console.Write("Please enter a length in feet: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Please enter a width in feet: ");
                double width = double.Parse(Console.ReadLine());

                Console.Write("Please enter a height in feet: ");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"The area of the room is: {length * width}" + " feet squared");

                Console.WriteLine($"The perimeter of the room is: {2 * length + 2 * width}" + " feet" );

                Console.WriteLine($"The volume of the room is: {length * width * height}" + " feet cubed");
}
    }
}
