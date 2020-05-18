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
        private int _countOneB;
        private int _countTwoB;
        private int _countThreeB;
        private int _totalCost;

        public BreadOrder()
        {
            _breadOne = "White Bread";
            _breadTwo = "French Bread";
            _breadThree = "Elven Bread";
            _costOne = 4;
            _costTwo = 6;
            _costThree = 780;
            _totalCost = 0;
            _countOneB = 0;  
            _countTwoB = 0;
            _countThreeB = 0; 
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

        public int GetCostOne()
        {
            return _costOne;
        }
        
        public int GetCountOne()
        {
            return _countOneB;
        }
        public int  GetCostTwo()
        {
            return _costTwo;
        }
        
        public int GetCountTwo()
        {
            return _countTwoB;
        }
        
        public int GetCostThree()
        {
            return _costThree;
        }
        
        public int GetCountThree()
        {
            return _countThreeB;
        }
        
        public int SetCountOne(int countOneB)
        {
            return _countOneB = countOneB;
        }
        
        public int SetCountTwo(int countTwoB)
        {
           return  _countTwoB = countTwoB;
        }
        
        public int SetCountThree(int countThreeB)
        {
           return  _countThreeB = countThreeB;
        }

        public int TotalPrice()
        {
            int _totalCost;
            if(_countOneB >= 2)
            {
                 _costOne = 2;
            } else if (_countTwoB >= 2)
            {
                 _costTwo = 3;
            } else if (_countThreeB >= 2)
            {
                 _costThree = 390;
            }
             _totalCost = _countOneB * _costOne + _countTwoB * _costTwo + _countThreeB * _costThree;
            return _totalCost;
        }
    }  
}
