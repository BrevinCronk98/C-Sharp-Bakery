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
            int countOneB = myBread.GetCountOne();
            int countTwoB = myBread.GetCountTwo();
            int countThreeB = myBread.GetCountThree();
            
            // Bread Program Sequence
            Console.WriteLine("Here is our Esteemed Bread Selection!: " + myBread.GetBreadOne() + " is " + myBread.GetCostOne() + " Dollars, " + myBread.GetBreadTwo() + " is " + myBread.GetCostTwo() + " Dollars, " + myBread.GetBreadThree() + " is " +  myBread.GetCostThree() + " Dollars. If You Buy 2 or More of Any Bread Type, you get 50% off all of them" );
            
            
           
            startB:
            Console.WriteLine("What Type of Bread Would You Like? To Make it Simple for you Guys, Press 1 for White Bread, Press 2 for French Bread, or Press 3 for Elven Bread, oooo");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                Console.WriteLine("How Many Slices of " + myBread.GetBreadOne() +" Would You Like");
                countOneB = myBread.SetCountOne(int.Parse(Console.ReadLine()));
            } else if(choice == "2")
            {
                Console.WriteLine("How Many Slices of " + myBread.GetBreadTwo() +" Would You Like");
                countTwoB = myBread.SetCountTwo(int.Parse(Console.ReadLine()));  
            } else if( choice == "3")
            {
                Console.WriteLine("How Many Slices of " + myBread.GetBreadThree() +" Would You Like");
                countThreeB = myBread.SetCountThree(int.Parse(Console.ReadLine())); 
            } else
            {
                Console.WriteLine("We Dont Have That Bread Thanks for Checking for Errors");
            }
            
            Console.WriteLine("Do You Want to Order More? Press Y for Yes, and N for No");
            string yes = Console.ReadLine().ToLower();
            if( yes == "y" || yes == "yes")
            {
                goto startB;
            } 
            
        
            // Adds Bread Ordered to Bread List
            Breads.Add(myBread);
            
            // Pastry Class Call
            List<PastryOrder> Pastries = new List<PastryOrder>(){};
            PastryOrder myPastry = new PastryOrder();

            // Pastry Class Variables
            int countOneP = myPastry.GetCountOne();
            int countTwoP = myPastry.GetCountTwo();
            int countThreeP = myPastry.GetCountThree();


            // Pastry Program Sequence
            Console.WriteLine("Here is our Exquisite Pastry Selection!: " + myPastry.GetPastryOne() + " are " + myPastry.GetCostOne() + " Dollars, " + myPastry.GetPastryTwo() + " are " + myPastry.GetCostTwo() + " Dollars, " + myPastry.GetPastryThree() + " are " +  myPastry.GetCostThree() + " Dollars. If You Buy 2 or More of Any Pastry, you get 50% off all of them" );
            
            
    
            startP:
            Console.WriteLine("What Type of Pastry Would You Like? To Make it Simple for you Guys, Press 1 for Cherry Danish, Press 2 for Bear Claw, or Press 3 for Jedi Pastries woahhhh.");
            string choiceTwo = Console.ReadLine();
            if(choiceTwo == "1")
            {
                Console.WriteLine("How Many Pieces of " + myPastry.GetPastryOne() +" Would You Like");
                countOneP = myPastry.SetCountOne(int.Parse(Console.ReadLine()));
            } else if(choiceTwo == "2")
            {
                Console.WriteLine("How Many Pieces of " + myPastry.GetPastryTwo() +" Would You Like");
                countTwoP = myPastry.SetCountTwo(int.Parse(Console.ReadLine()));  
            } else if( choiceTwo == "3")
            {
                Console.WriteLine("How Many Pieces of " + myPastry.GetPastryThree() +" Would You Like");
                countThreeP = myPastry.SetCountThree(int.Parse(Console.ReadLine())); 
            } else
            {
                Console.WriteLine("We Dont Have That Pastry Thanks for Checking for Errors");
            }
            
            Console.WriteLine("Do You Want to Order More? Press Y for Yes, and N for No");
            string yesTwo = Console.ReadLine().ToLower();
            if( yesTwo == "y" || yesTwo == "yes")
            {
                goto startP;
            } 
        
        

            Pastries.Add(myPastry);
            
            int TotalCostBread = myBread.TotalPrice();
            int TotalCostPastry = myPastry.TotalPrice();
            
            int FinalCost = TotalCostBread + TotalCostPastry;
            Console.WriteLine( "Your Order Total is " + FinalCost + " Dollars. You Spent " + TotalCostBread + " Dollars On Bread and " + TotalCostPastry + " Dollars On Pastries");
        }
    }
}