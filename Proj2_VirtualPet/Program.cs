using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2_VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how we instantiate a new instance of our pet
            //I did the exact same thing before I don't know why it isn't working this time.
            //I believe this is what is causing problems in my method below. When cases are listed.
            VirtualPet myPet = new VirtualPet;

            //Greeting:This will be a welcoming to the game. 
            Console.WriteLine("Welcome, I am happy you decided to come and play our game!");
            Console.WriteLine("Your job is to take care of a puppy that needs a new home!");
            Console.WriteLine("Make sure you pay attention to all of it's needs, good luck!\n");

            //User is prompted to name pet.
            Console.WriteLine("What will you name your new puppy?");
            Console.ReadLine();

            //Interactions: Gives user options to care for the pet
            Console.WriteLine();
            Console.WriteLine("Please select an option:\n");
            Console.WriteLine("1.Feed the puppy");
            Console.WriteLine("2.Play with puppy");
            Console.WriteLine("3.Give puppy water");
            Console.WriteLine("4.Take puppy to bathroom");
            Console.WriteLine("5.Bathe puppy");
            Console.WriteLine("6.Quit\n");

            //Call Method-Originally used on template
         
             myPet.MyPetStatus();

            //There are 6 options for the pet so I set the variable to 6
            int selectedOption = 6;

            //Using a switch statement because we are using a sequence of case statements
            //Default statement will be used at the end-It is used to route the flow of the method if a case doesn't match
                       
           switch (selectedOption)
            {
                case 1:

                    myPet.HungerDecrease();
                    Console.WriteLine("Thank you for feeding the pet. He loves to eat!");
                    break;

                case 2:

                    myPet.BoredomIncreases();
                    Console.WriteLine("Thank you for playing with the pet!");

                case 3:

                    myPet.ThirstIncreases();
                    Console.WriteLine("Thank you for the water!");

                case 4:

                    myPet.ThirstDecreases();
                    Console.WriteLine("Thanks for taking me on a walk!");

                case 5:

                    myPet.BoredomDecreased();
                    Console.WriteLine("Feelin'fresh and so clean, clean. Thanks!");
                    
                case 6:
                                   
                    Console.WriteLine("Thanks for playing!");
                    break;

                default:

                    Console.WriteLine("Invalid option selected.");
                    break;
            }



         }
    }
}
