using System;

namespace RoomCalculator
{
    class Program
    {


        private static double calculateArea()
        {
            Console.Write("What is the length of this room? ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("What is the width of this room? ");
            double width = double.Parse(Console.ReadLine());
            double area = width * length;
            Console.WriteLine("The length of " + length + " and the width of " + width + " with an area of " + area);
            calculatePerimeter(length, width);
            checkSize(area);
            proceed();
            return area;
        }

        private static void proceed()
        {
            Console.Write("Would you like to proceed?  Y/N");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {
                calculateArea();
            }
            else
            {
                System.Environment.Exit(0);

            }
        }

        private static string checkSize(double area)
        {
            string roomSize = "";
            if(area <= 250)
            {
                roomSize = "Small";
            }
            else if(area <= 650)
            {
                roomSize = "Medium";
            }
            else
            {
                roomSize = "Large";
            }
            Console.WriteLine("This room size is " + roomSize + ".");
            return roomSize;
        }

        private static double calculatePerimeter(double length, double width)
        {

            double perimeter = 2 * (length + width);
            Console.WriteLine("The length of " + length + " and the width of " + width + " with a perimeter of " + perimeter);
            return perimeter;
        }



        static void Main(string[] args)
        {

            calculateArea();
            
            
        }


    }
}
