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
            myBread.Game();
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