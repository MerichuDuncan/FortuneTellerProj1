using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan9
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, coloR;
          

            //part 1
            Console.WriteLine("What's your First Name?");
            firstName = Console.ReadLine();

            Console.WriteLine("\n"+"What is your Last Name?");
            lastName = Console.ReadLine();

            Console.WriteLine("\n"+"How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\n"+"Enter birth month as a number?");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("\n"+"What's your favorite ROYGBIV COLOR? If don't know what ROYGBIV is, please enter help");
            coloR = Console.ReadLine();

            coloR = coloR.ToLower();
            if (coloR == "help")



            {
                Console.WriteLine("R-Red, O-Orange, Y-Yellow, G-Green, B-Blue, I-Indigo, V-Violet");

                Console.WriteLine("\n"+"What's your favorite ROYGBIV color?");
                coloR = Console.ReadLine();

            }

            Console.WriteLine("\n"+"How many siblings do you have?");
            int sibs = int.Parse(Console.ReadLine());


            Console.WriteLine("\n"+firstName + " " + lastName);



            //part 2
            // If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
            if (age % 2 == 0)

            {
                Console.WriteLine("You will retire in 5 years.");
            }

            else

            {
                Console.WriteLine("You will retire in 10 years.");
            }


            // If the user’s number of siblings is 0, then they will have a vacation home in __(location), 
            //or 1 then they will have a vacation home in __(location), or 2 then they will have a vacation home in ___ (location)
            //, or 3 then they will have a vacation home in ___ (location), 
            //or more than 3 then they will have a vacation home in ____ (location). 
            //If the user enters anything other than a number greater than or equal to 0, they should get a bad vacation home!

            if (sibs == 0)
            {
                Console.WriteLine("You will have a vacation home in Greece.");
            }

            else if (sibs == 1)
            {
                Console.WriteLine("You will have a vacation home in China.");

            }
            else if (sibs == 2)

            {
                Console.WriteLine("You will have a vacation home in Florida.");
            }

            else if (sibs == 3)
            {
                Console.WriteLine("You will have a vacation home in Japan.");
            }

            else if (sibs >= 3)
            {
                Console.WriteLine("You will have a vacation home in Cleveland, Ohio.");

            }

            
            else if (sibs <=0)
            {
                Console.WriteLine("You will have a vacation in Afghanistan, good luck!");
            }


            // Depending on which ROYGBIV color is the user’s favorite, they will have a specific mode of transportation (i.e. car, boat, plane, etc.) 

            coloR = coloR.ToLower();

            if (coloR == "red" || coloR == "orange" || coloR == "yellow" || coloR == "blue" || coloR == "indigo" || coloR == "violet")

                switch (coloR)

                {
                    case "red":
                        Console.WriteLine("You will be driving a red audi to work tomorrow.");
                        break;

                    case "orange":
                        Console.WriteLine("You will be taking an orange helicopter to starbucks tomorrow.");
                        break;

                    case "yellow":
                        Console.WriteLine("You will be driving a chevy camaro to see your friends tomorrow.");
                        break;

                    case "blue":
                        Console.WriteLine("You will be on a plane to Hawaii tomorrow.");
                        break;

                    case "indigo":
                        Console.WriteLine("You will be riding a scooter to get groceries tomorrow.");
                        break;

                    case "violet":
                        Console.WriteLine("You will be driving a mini cooper next friday going to Canada.");
                        break;

                    default:
                        Console.WriteLine("You are confused in life!");
                        break;


                }

          


            // If the user’s birth month is 1-4, they will have $____ in the bank; 
            //if the user's birth month is 5-8, they will have $____ in the bank; 
            //and if it is 9-12, then they will have $____ in the bank. If the user enters something other 
            //than 01-12 as their birth month, they will have $0.00 in the bank.

            if (month >= 1 || month <= 4)
            {
                Console.WriteLine("You will have $15,000 in the bank.");

            }

            else if (month >= 5 || month <= 8)

            {
                Console.WriteLine("You will have $5,000 in the bank.");
            }

            else if (month >=9 || month <= 12)

            {
                Console.WriteLine("You will have $2 in the bank.");
            }

            else

            {
                Console.WriteLine("You have $0 in the bank.");
            }
           


            //part 3
            // The user’s fortune should be written as such: 
            //[First Name]
            //[Last Name]
            //will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            //Program should be able to handle whether or not a user inputs capital or lowercase letters.

        }
    }

}





