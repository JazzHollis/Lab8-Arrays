using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index >20)
                

            {

                //Place while loop after strings

                //try not to return multiple variables for methods


                //1. Set Up Database
                Console.WriteLine("Welcome to C# class. Which student would you " +
                    "like to learn more about?enter a number 1-20");

              

                string[] Students = { "Kim", "Dorain", "Jackson", "Laura", "Daphne", "Marcellus", "Shaniqua","John",
                                  "Josiah","Jacob", "Alexis", "Cynthia", "Mark", "Chad", "Doris", "Rhonda", "Destiny", "Isaiah", "Katelyn", "Zamira"};


                string[] Hometown = { "Detroit","Seattle", "Chicago", "Atlanta", "New York", "St. Clair Shores", "Beverly Hills",
                                  "Southfield", "Nashville", "Sacremento", "Phoenix", "Rio de Janeiro", "Paris", "Dallas",
                                  "Los Angeles", "Lagos","Washington D.C.", "Seattle", "Detroit", "Denver"};

                string[] FavoriteFood = { "Pizza", "Nachos", "Chicken Alfredo", "Greek Salad", "Black Bean Burger", "Spaghetti", "Quiche",
                                      "Raviolli", "Samosas", "Lentil Kibbee","Fufu", "Taboulli", "BBQ Ribs", "Corn on the Cob",
                                      "Chimichanga", "Cole Slaw", "BLT sandwich", "Grinder Sub", "Chicken Salad"};


                Console.WriteLine("What would you like to know about " + Students[index - 1] + " (enter 'h' for hometown and 'f' for favorite food");
                string option1 = Console.ReadLine();

                if (option1.ToLower().Contains("h"))
                {
                    Console.WriteLine(Students[index - 1] + "'s" + " hometown is " + Hometown[index - 1]);
                }

                else if (option1.ToLower().Contains("f"))
                {
                    Console.WriteLine(Students[index - 1] + "'s " + "favorite food is " + FavoriteFood[index - 1]);
                }

                else
                {
                    Console.WriteLine("Invalid input! Please try again!");
                }

                Console.WriteLine("Would you like to select another student?(y/n)");
                string choice = Console.ReadLine();
                if (choice == "n")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

            }
               
        }



    }




        //2. Ask the user what they want to look for (index)

        //3.Use Index to print name

        //4. Ask about the information they want to look for (favorite food/hometown)

        //5.Print information

}

        
    

