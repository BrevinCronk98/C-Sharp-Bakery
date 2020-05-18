using System;


namespace Order.Pastry
{
    public class PastryOrder
    {
         private string _pastryOne;
        private string _pastryTwo;
        private string _pastryThree;
        private string _pastryType;
        private int _costOne;
        private int _costTwo;
        private int _costThree;
        private int _countOneP;
        private int _countTwoP;
        private int _countThreeP;
        private int _totalCost;

        public  PastryOrder()
        {
            _pastryOne = "Cherry Danishs";
            _pastryTwo = "Bear Claws";
            _pastryThree = "Jedi Pastries";
            _costOne = 4;
            _costTwo = 6;
            _costThree = 500;
            _totalCost = 0;
            _countOneP = 0;  
            _countTwoP = 0;
            _countThreeP = 0; 
        }

      

        public string GetPastryOne()
        {
            return _pastryOne;
        }
        
        public string GetPastryTwo()
        {
            return _pastryTwo;
        }
        
        public string GetPastryThree()
        {
            return _pastryThree;
        }
        
        public int GetCostOne()
        {
            return _costOne;
        }
       
        public int GetCountOne()
        {
            return _countOneP;
        }
        
        public int  GetCostTwo()
        {
            return _costTwo;
        }
        
        public int GetCountTwo()
        {
            return _countTwoP;
        }
        
        public int GetCostThree()
        {
            return _costThree;
        }
        
        public int GetCountThree()
        {
            return _countThreeP;
        }

         public int SetCountOne(int countOneP)
        {
            return _countOneP = countOneP;
        }
        
        public int SetCountTwo(int countTwoP)
        {
           return  _countTwoP = countTwoP;
        }
        
        public int SetCountThree(int countThreeP)
        {
           return  _countThreeP = countThreeP;
        }
        


         public int TotalPrice()
        {
            int _totalCost;
            if(_countOneP >= 2)
            {
                _costOne = 2;
            } else if (_countTwoP >= 2)
            {
                _costTwo = 3;
            } else if (_countThreeP >= 2)
            {
                _costThree = 250;
            }
             _totalCost = _countOneP * _costOne + _countTwoP * _costTwo + _countThreeP * _costThree;
            return _totalCost;
        }
    }
}