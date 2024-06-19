using System;

namespace hbc
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DISCLAIMER: This program calculates an estimated hook board position based on user inputs such as ball type, RPM, axis rotation, lane conditions, and ball speed. Results provided are approximate and may vary in real-world bowling conditions. Use this tool for informational purposes only. For precise bowling strategies, consult with a qualified coach or technician.");
            Console.ResetColor();
            Console.WriteLine("Hook Board Calculator");
            Console.WriteLine("by lucazdev189");
            Console.WriteLine(" ");
            Console.WriteLine("Enter initial board:");

            double initBoard = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Coverstock Factor (the number):");
            Console.WriteLine("(Plastic = 0.8, Urethane = 1.0, Pearl = 1.2, Solid = 1.5, HyBrid = 1.35)");

            double coverstockFactor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter RPM:");

            double rpm = Convert.ToDouble(Console.ReadLine()) / 325;

            Console.WriteLine("Enter Axis Rotation:");

            double axisRotation = Convert.ToDouble(Console.ReadLine()) / 45;

            Console.WriteLine("Enter Axis Tilt:");

            double axisTilt = Convert.ToDouble(Console.ReadLine()) / 45;

            Console.WriteLine("Enter speed in mph:");

            double speed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Oil Length:");

            double oilLength = Convert.ToDouble(Console.ReadLine()) / 42;

            Console.WriteLine("Enter Lane Condition (the number):");
            Console.WriteLine("Dry = 1.5, Medium = 1.0, Heavy = 0.5");

            double laneCondition = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Targeted Board:");

            double targetBoard = Convert.ToDouble(Console.ReadLine());

            double hookBoard = Math.Round((initBoard + (coverstockFactor / rpm / axisRotation / oilLength / axisTilt / laneCondition / speed)) - targetBoard, 2);

            Console.WriteLine("Your ball would hook at the " + hookBoard + " board.");

            Console.ReadKey();
        }
    }
}