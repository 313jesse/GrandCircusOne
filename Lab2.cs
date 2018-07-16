using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calculateAgain = true;
            while (calculateAgain)

            {
                double Length = 0;
                double Width = 0;
                double Height = 10;

                Console.WriteLine("Please enter the Length of the room in feet, then press ENTER.");
                Length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please Enter the Width of the room in feet, then press ENTER.");
                Width = Convert.ToDouble(Console.ReadLine());

                var area = (Length * Width);
                var perimeter = (Length * 2) + (Width * 2);
                var volume = (Length * Width * Height);

                Console.WriteLine("The area of the room is " + area + " Sqare FT.");

                Console.WriteLine("The perimiter of the room is " + perimeter + "Linear FT.");

                Console.WriteLine("The volume of the room is " + volume + " FT Cubed.");


                Console.WriteLine("Would you like to calculate another room? (Y/N): ");
                string tryAgain = Console.ReadLine();

                if (tryAgain == "y" || tryAgain == "Y")
                    calculateAgain = true;

                else if (tryAgain == "N" || tryAgain == "N")

                    calculateAgain = false;

                else
                {
                    Console.WriteLine("I'll take that as a no...");
                    calculateAgain = false;
                }
            }
        }

    }

}
    
