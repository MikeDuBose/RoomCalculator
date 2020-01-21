using System;

namespace RoomCalculator
{
    class Program
    {


        
        //Method that calculates the area and makes the call to other methods
        private static double calculateArea()
        {
            //Receive user input
            Console.Write("What is the length of this room? ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("What is the width of this room? ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("What is the height of this room? ");
            double height = double.Parse(Console.ReadLine());
            double area = width * length;
            Console.WriteLine("The room has an area of " + area + ".");
            calculateVolume(length, width, height);
            calculatePerimeter(length, width);
            checkSize(area);
            //This checks with the user to see if they would like to continue.
            proceed();
            return area;
        }

        //Method that calculates the volume of the user input
        private static double calculateVolume(double length, double width, double height)
        {
            double volume = length * width * height;
            Console.WriteLine("The room has a volume of " + volume + ".");
            return volume;
        }

        private static void proceed()
        {
            Console.Write("Would you like to proceed?  Y/N:  ");
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
            Console.WriteLine("The room has a preimeter of " + perimeter + ".");
            return perimeter;
        }



        static void Main(string[] args)
        {
            //By placing this WriteLine here, I ensure that it is only called once and not every time calculateArea() is called.
            Console.WriteLine("Hello and welcome to Room Sizer 2.0!  Now 50% less deadly than our last version!  Please answer the following questions: ");
            calculateArea();
            
            
        }


    }
}
