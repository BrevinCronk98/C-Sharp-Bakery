using System;
using System.Collections.Generic;
using Order.Bread;
using Order.Pastry;

namespace Order
{
    public class Program
    {
        public static void Main()
        {
            // Bread Class Call
            List<BreadOrder> Breads = new List<BreadOrder>(){};
            BreadOrder myBread = new BreadOrder();
            
            // Bread Class Variables
            string breadType = myBread.GetBreadType();
            int countOne = myBread.GetCountOne();
            int countTwo = myBread.GetCountTwo();
            int countThree = myBread.GetCountThree();
            
            // Bread Program Sequence
            Console.WriteLine("Here is our Esteemed Bread Selection!: " + myBread.GetBreadOne() + " is " + myBread.GetCostOne() + " Dollars, " + myBread.GetBreadTwo() + " is " + myBread.GetCostTwo() + " Dollars, " + myBread.GetBreadThree() + " is " +  myBread.GetCostThree() + " Dollars.." );
            int num = 1;
            
            for(int i = 0; i < num; i ++)
            {
                start:
                Console.WriteLine("What Type of Bread Would You Like? To Make it Simple for you Guys, Press 1 for White Bread, Press 2 for French Bread, or Press 3 for Elven Bread, oooo");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    breadType = myBread.GetBreadOne();
                    Console.WriteLine("How Many Slices of " + myBread.GetBreadType() +" Would You Like");
                    countOne = myBread.SetCountOne(int.Parse(Console.ReadLine()));
                } else if(choice == "2")
                {
                    breadType = myBread.GetBreadTwo();
                    Console.WriteLine("How Many Slices of " + myBread.GetBreadType() +" Would You Like");
                    countTwo = myBread.SetCountTwo(int.Parse(Console.ReadLine()));  
                } else if( choice == "3")
                {
                    breadType = myBread.GetBreadThree();
                    Console.WriteLine("How Many Slices of " + myBread.GetBreadType() +" Would You Like");
                    countThree = myBread.SetCountThree(int.Parse(Console.ReadLine())); 
                } else
                {
                    Console.WriteLine("We Dont Have That Bread Thanks for Checking for Errors");
                }

                Console.WriteLine("Do You Want to Order More? Press Y for Yes, and N for No");
                string yes = Console.ReadLine().ToLower();
                if( yes == "y" || yes == "yes")
                {
                    goto start;
                } else
                {
                    break;
                }
            }

            Breads.Add(myBread);
            
            
            // List<PastryOrder> Pastries = new List<PastryOrder>(){};
            // PastryOrder myPastry = new PastryOrder();
            // myPastry.Game();
            // Pastries.Add(myPastry);
            
            int TotalCostBread = myBread.TotalPrice();
            // int TotalCostPastry =  myPastry.GetCountOne() * myPastry.GetCostOne() + myPastry.GetCountTwo() * myPastry.GetCostTwo() + myPastry.GetCountThree() * myPastry.GetCostThree();
            int FinalCost = TotalCostBread;
            Console.WriteLine( "Your Order Total is " + FinalCost + " Dollars.");
        }
    }
}