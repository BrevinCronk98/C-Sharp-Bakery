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
            List<BreadOrder> Breads = new List<BreadOrder>(){};
            BreadOrder myBread = new BreadOrder();
            Console.WriteLine("Here is our Esteemed Bread Selection!: " + _breadOne + " is " + _costOne + " Dollars, " + _breadTwo + " is " + _costTwo + " Dollars, " + _breadThree + " is " +  _costThree + " Dollars.." );
            int num = 1;
            
            for(int i = 0; i < num; i ++)
            {
                Console.WriteLine("What Type of Bread Would You Like? To Make it Simple for you Guys, Press 1 for White Bread, Press 2 for French Bread, or Press 3 for Elven Bread, oooo");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    _breadType = _breadOne;
                    Console.WriteLine("How Many Slices of " + _breadType +" Would You Like");
                     _countOne = int.Parse(Console.ReadLine());
                   
                } else if(choice == "2")
                {
                    _breadType = _breadTwo;
                    Console.WriteLine("How Many Slices of " + _breadType +" Would You Like");
                    _countTwo = int.Parse(Console.ReadLine());
                   
                } else if( choice == "3")
                {
                    _breadType = _breadThree;
                    Console.WriteLine("How Many Slices of " + _breadType +" Would You Like");
                    _countThree = int.Parse(Console.ReadLine());
                   
                } else
                {
                    Console.WriteLine("We Dont Have That Bread Thanks for Checking for Errors");
                }

                
                Console.WriteLine("Do You Want to Order More? Press Y for Yes, and N for No");
                string yes = Console.ReadLine();
            }
            Breads.Add(myBread);
            
            
            List<PastryOrder> Pastries = new List<PastryOrder>(){};
            PastryOrder myPastry = new PastryOrder();
            myPastry.Game();
            Pastries.Add(myPastry);
            
            int TotalCostBread = myBread.GetCountOne() * myBread.GetCostOne() + myBread.GetCountTwo() * myBread.GetCostTwo() + myBread.GetCountThree() * myBread.GetCostThree();
            int TotalCostPastry =  myPastry.GetCountOne() * myPastry.GetCostOne() + myPastry.GetCountTwo() * myPastry.GetCostTwo() + myPastry.GetCountThree() * myPastry.GetCostThree();
            int FinalCost = TotalCostBread + TotalCostPastry;
            Console.WriteLine( "Your Order Total is " + FinalCost + " Dollars.");
        }
    }
}