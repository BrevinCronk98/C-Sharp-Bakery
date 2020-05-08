using System;


namespace Order.Pastry
{
    public class PastryOrder
    {
        private string _name;
        private int _cost;
        private int _count;

        public  PastryOrder()
        {
            _name = "Jelly Danish";
            _cost = 4;
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
            Console.WriteLine("We Offer " + _name + "es  For The Price of " + _cost + " Dollars Each" );
            Console.WriteLine("How Many Pastries Would You Like?");
            _count = int.Parse(Console.ReadLine());
            Console.WriteLine("You would like " + _count + " Pastries.");
            
        }
    }
}