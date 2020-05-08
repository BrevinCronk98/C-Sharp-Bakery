using System;


namespace Order.Bread
{
    public class BreadOrder
    {
        private string _name;
        private int _cost;

        public BreadOrder()
        {
            _name = "White Bread";
            _cost = 3;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetCost()
        {
            return _cost;
        }


        public void StartGame()
        {
           onStart();
        }

        private void onStart()
        {

            
            Console.WriteLine("We Offer " + _name + "For The Price of " + _cost + " Dollarss" );
          
        }
    }
    
}