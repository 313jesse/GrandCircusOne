using System;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                //user enters two seperate numbers

                string usernumber1;
                string usernumber2;
                Console.WriteLine("Please enter a four digit number and press ENTER");
                usernumber1 = Console.ReadLine();

                Console.WriteLine("Please enter a second four digit number and press ENTER");
                usernumber2 = Console.ReadLine();


                {
                    //validates numbers are of equal length
                    if (usernumber1.Length != usernumber2.Length)
                        Console.WriteLine("Please be sure your numbers are the same length!");
                    runProgram = false;

                }

                // converts the string to an integer
                //for the ability to add them together
                {
                    int first1 = Convert.ToInt32(new string(usernumber1[0], 1));
                    int second1 = Convert.ToInt32(new string(usernumber2[0], 1));

                    int firstsum = first1 + second1;

                    int first2 = Convert.ToInt32(new string(usernumber1[1], 1));
                    int second2 = Convert.ToInt32(new string(usernumber2[1], 1));

                    int secondsum = first2 + second2;


                    int first3 = Convert.ToInt32(new string(usernumber1[2], 1));
                    int second3 = Convert.ToInt32(new string(usernumber2[2], 1));

                    int thirdsum = first3 + second3;


                    int first4 = Convert.ToInt32(new string(usernumber1[3], 1));
                    int second4 = Convert.ToInt32(new string(usernumber2[3], 1));

                    int fourthsum = first4 + second4;
                    {
                        if (firstsum == secondsum)
                            if (secondsum == thirdsum)
                                if (thirdsum == fourthsum)
                                    Console.WriteLine("True");
                                else Console.WriteLine("False");
                    }

                    // repeats the program or cancels based on user response

                    Console.WriteLine("Would you like to try again? (Y/N): ");
                    string tryAgain = Console.ReadLine();

                    if (tryAgain == "y" || tryAgain == "Y")
                    {
                        runProgram = true;
                    }
                    else if (tryAgain == "N" || tryAgain == "N")
                    {
                        runProgram = false;
                    }
                    else
                    {
                        Console.WriteLine("I'll take that as a no...");
                        runProgram = false;

                 
                        {

                        }
                    }


                }

            }
        }
    }
}
