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
            List<PastryOrder> Pastries = new List<PastryOrder>(){};
            PastryOrder myPastry = new PastryOrder();
            myPastry.Game();
            // int totalPrice = myPastry.GetCount() * myPastry.GetCost() + myBread.GetCount() + myBread.GetCost();
            // Console.Write("Your Order Total is  " + totalPrice + " Dollars");          
        }
    }
}