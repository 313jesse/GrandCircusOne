using System;

namespace TimeBetweenDates
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            DateTime firstDate;
            DateTime secondDate;

            Console.WriteLine("Enter the first Date in dd/mm/yyyy format, then press ENTER.");
            firstDate = Convert.ToDateTime(Console.ReadLine()).Date;

            Console.WriteLine("Enter the second Date in dd/mm/yyyy format, then press ENTER.");
            secondDate = Convert.ToDateTime(Console.ReadLine()).Date;

            var difference = secondDate.Subtract(firstDate);

            Console.WriteLine("The difference is " + difference.Days + " days.");
            Console.WriteLine("The difference is " + difference.Days*24 + " hours.");
            Console.WriteLine("The difference is " + difference.Days*24*60 + " Minutes.");

            Console.ReadLine();

        }
    }
}
