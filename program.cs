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
            myBread.StartGame();
            List<PastryOrder> Pastries = new List<PastryOrder>(){};
            PastryOrder myPastry = new PastryOrder();
            myPastry.StartGame();
           
        }
    }
}