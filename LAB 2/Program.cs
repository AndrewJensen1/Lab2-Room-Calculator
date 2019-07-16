using System;

namespace LAB_2
{
    class Program
    {
        static void Main(string[] args)
        {


            bool continueloop = true;
            while (continueloop == true)
            {
                Console.WriteLine("If you would like to find the area, perimeter or volume of a room please type yes or no");
                string userinput = Console.ReadLine();

                if (userinput == "yes" || userinput == "YES" || userinput == "Yes" || userinput == "y" || userinput == "Y")
                {
                    continueloop = true;

                    Console.WriteLine("What is the Lenth of the room?");
                    double lenght = double.Parse(Console.ReadLine());
                    Console.WriteLine("What is the Width of the room?");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("What is the Height of the room?");
                    double height = double.Parse(Console.ReadLine());

                    double area = lenght * width;
                    double perimeter = 2 * (lenght + width);
                    double volume = lenght * width * height;

                    Console.WriteLine("The Area of the room is:" + area);
                    Console.WriteLine("The Perimeter of the room is:" + perimeter);
                    Console.WriteLine("The Volume of the room is:" + volume);

                    Console.WriteLine("\n");
                    Console.WriteLine("If you would like to run the program again? Please type Yes or No");
                    string userinput2 = Console.ReadLine();
                    if (userinput2 == "yes" || userinput2 == "YES" || userinput2 == "Yes" || userinput2 == "y" || userinput2 == "Y")
                    {
                        continueloop = true;
                    }
                    else
                    {
                        continueloop = false;
                    }
                        }
                else
                {
                    continueloop = false;
                }
            }    
        }
    }
}
