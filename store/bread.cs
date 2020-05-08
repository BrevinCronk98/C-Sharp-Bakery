using System;
using Order.Pastry;


namespace Order.Bread
{
    public class BreadOrder
    {
        private string _name;
        private int _cost;
        private int _count;

        public BreadOrder()
        {
            _name = "White Bread";
            _cost = 3;
            _count = 0;   
        }
        public string GetName()
        {
            return _name;
        }
        public int GetCost()
        {
            return _cost;
        }
        public int GetCount()
        {
            return _count;
        }

        public void Game()
        {
           OnStart();
        }




        private void OnStart()
        {
            Console.WriteLine("We Offer " + _name + " For The Price of " + _cost + " Dollars Each" );
            Console.WriteLine("How Many Pieces of Bread Would You Like?");
            _count = int.Parse(Console.ReadLine());
            Console.WriteLine("You would like " + _count + " Pieces of Bread");
        }
    }
    
}