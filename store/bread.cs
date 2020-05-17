using System;



namespace Order.Bread
{
    public class BreadOrder
    {
        private string _breadOne;
        private string _breadTwo;
        private string _breadThree;
        private string _breadType;
        private int _costOne;
        private int _costTwo;
        private int _costThree;
        private int _countOne;
        private int _countTwo;
        private int _countThree;
        private int _totalCost;

        public BreadOrder()
        {
            _breadOne = "White Bread";
            _breadTwo = "French Bread";
            _breadThree = "Elven Bread";
            _breadType = "White Bread";
            _costOne = 3;
            _costTwo = 4;
            _costThree = 780;
            _totalCost = 0;
            _countOne = 0;  
            _countTwo = 0;
            _countThree = 0; 
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

        public string GetBreadType()
        {
            return _breadType;
        }
        public int GetCostOne()
        {
            return _costOne;
        }
        public int GetCountOne()
        {
            return _countOne;
        }
        public int  GetCostTwo()
        {
            return _costTwo;
        }
        public int GetCountTwo()
        {
            return _countTwo;
        }
        public int GetCostThree()
        {
            return _costThree;
        }
        public int GetCountThree()
        {
            return _countThree;
        }
       
        public void Game()
        {
           OnStart();
           TotalPrice();
        }

        private void TotalPrice()
        {
            
            int _totalCost = _countOne * _costOne + _countTwo * _costTwo + _countThree * _costThree;
            Console.WriteLine("Your order so far is " + _totalCost + " Dollars");
        }
    }  
}
