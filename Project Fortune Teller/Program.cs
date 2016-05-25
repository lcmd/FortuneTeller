using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            string retireAge = "";
            string bank = "";
            string city = "";
            string transport = "";
            //string help;

            string playAgain = "N";
            string[] responses = { "", "" };
            var max = responses.Length;
            Random random = new Random();
            do
            {

                Console.WriteLine("Welcome to Your Fortune Teller");

                Console.Write("First Name: ");
                string firstName = Console.ReadLine().ToLower();
                // string firstNameLow = firstName.ToLower();

                Console.Write("Last name: ");
                string lastName = Console.ReadLine().ToLower();
                //string lastNameLow = lastName.ToLower();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Birth Month: ");
                string month = Console.ReadLine().ToLower();
                //string monthLower = month.ToLower();

                Console.Write("Favorite ROYGBIV color (If you don't know what ROYGBIV colors are enter \"Help\" to show a list of colors): ");
                string favColor = Console.ReadLine().ToLower();
                // string favColorLower = favColor.ToLower();

                if (favColor == "help")
                {

                    Console.WriteLine("ROYGIV Colors: \nR is Red, \nO is Orange, \nY is Yellow, \nG is Green, \nB is Blue, \nI is indigo, \nV is violet");
                    favColor = Console.ReadLine().ToLower();
                    // Console.WriteLine("Please enter a color: ");
                    //string helpColor = (Console.ReadLine());

                }
                switch (favColor)
                {
                    case "red":
                        transport = "Tricycle";

                        break;
                    case "orange":
                        transport = "Skateboard";

                        break;
                    case "yellow":
                        transport = "VW Bus";

                        break;
                    case "green":
                        transport = "Unicorn";

                        break;
                    case "blue":
                        transport = "Lexus";

                        break;
                    case "indigo":
                        transport = "Sedan";

                        break;
                    case "violet":
                        transport = "Mechanical Bull";
                        break;
                        default:
                        transport = "Maybach Mercedes-Benz";
                           break;

                }

                //  Console.WriteLine("Your means of transportation is a " + transport);

                Console.Write("Number of Siblings: ");
                int siblings = int.Parse(Console.ReadLine());

                if (age % 2 == 0)
                {
                    retireAge = 20.ToString();
                }
                else
                {
                    retireAge = 25.ToString();
                }
                //  Console.WriteLine("You will retire in " + retireAge + " " + "years");

                if (firstName.IndexOf(month[0]) != -1 || lastName.IndexOf(month[0]) != -1)
                {
                    bank = "2.5 million";
                }
                else if
                    (firstName.IndexOf(month[1]) != -1 || lastName.IndexOf(month[1]) != -1)
                {
                    bank = "3 million";
                }
                else if
                    (firstName.IndexOf(month[2]) != -1 || lastName.IndexOf(month[2]) != -1)
                {
                    bank = "5 million";
                }
                else
                {
                    bank = "100 million";
                }
                // Console.WriteLine("your net worth is " + bank);

                //DESTINATION SWiTCh CASE (siblings)
                switch (siblings)
                {
                    case 0:
                        city = "Marrakesh, Morocco";
                        break;
                    case 1:
                        city = "Sarasota, FL";
                        break;
                    case 2:
                        city = "Vancouver, BC";
                        break;
                    case 3:
                        city = "Boise, ID";
                        break;
                    default:
                        city = "Basel, Switzerland";
                        break;
                }
                // Console.WriteLine("The city you will live in is " + city); 

                Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank, a vacation home in {4} and a {5}.", firstName, lastName, retireAge, bank, city, transport);

                var selectedNum = random.Next(max);
                Console.WriteLine(responses[selectedNum]);
                Console.WriteLine("Would you like to play again (Y or N)?");
                playAgain = Console.ReadLine().ToLower();

            }
            while (playAgain == "y");
        }
    }
}
