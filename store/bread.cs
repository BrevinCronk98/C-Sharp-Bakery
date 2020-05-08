using System;



namespace Order.Bread
{
    public class BreadOrder
    {
        private string _breadOne;
        private string _breadTwo;
        private string _breadThree;
        private int _costOne;
        private int _costTwo;
        private int _costThree;
        private int _count;
        private int _totalCost;

        public BreadOrder()
        {
            _breadOne = "White Bread";
            _breadTwo = "French Bread";
            _breadThree = "Elven Bread";
            _costOne = 3;
            _costTwo = 4;
            _costThree = 780;
            _totalCost = 0;
            _count = 0;   
        }
        public string GetBreadOne()
        {
            return _breadOne;
        }
         public string GetBreadTwo()
        {
            return _breadTwo;
        }
         public string GetBreadThree()
        {
            return _breadThree;
        }

        public int GetTotalCost()
        {
            return _totalCost;
        }
       
        public void Game()
        {
           OnStart();
        }

        private void OnStart()
        {
            Console.WriteLine("Here is our Esteemed Bread Selection!: " + _breadOne + " is " + _costOne + " Dollars, " + _breadTwo + " is " + _costTwo + " Dollars, " + _breadThree + " is " +  _costThree + " Dollars.." );
            Console.WriteLine("How Many Pieces of Bread Would You Like?");
            _count = int.Parse(Console.ReadLine());
            Console.WriteLine("You would like " + _count + " Pieces of Bread");
        }
    }
    
}