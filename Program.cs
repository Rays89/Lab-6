using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {

        static Random rnd = new Random();

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n):");

            String input = Console.ReadLine();
            while (true)
            {

                //ask user for dice sides
                Console.WriteLine();
                Console.WriteLine("How many number of sides should each die have");

                string sides = Console.ReadLine();
                int numbersides = int.Parse(sides);// converted the number into a integer 



                //prompt user for dice roll
                Console.WriteLine();
                Console.WriteLine("Do you want to roll the dice?");

                string responce = Console.ReadLine();
                if (responce == "exit")

                {



                    return;
                }
                int rolledNum = RollDice(numbersides);
                int rolledNumTwo = RollDice(numbersides);


                //display what they have rolled
                Console.WriteLine();
                Console.WriteLine($"\tRoll 1:");
                Console.WriteLine($"\t{rolledNum}");
                Console.WriteLine($"\t{rolledNumTwo}");

                //ask if user wants to continue
                Console.WriteLine();
                Console.WriteLine("Would you like to play or Roll again?");
                responce = Console.ReadLine();
                if (responce.ToLower() != "y")

                    return;

            }



        }

        static int RollDice(int numbersides)
        {




            int num = rnd.Next(1, numbersides);


            return num; // we are returning that value


        }

    }
}





       