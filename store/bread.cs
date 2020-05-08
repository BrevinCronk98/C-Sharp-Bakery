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
            int num = 1;
            
            for(int i = 0; i < num; i ++)
            {
                Console.WriteLine("What Type of Bread Would You Like?");
                _breadType = Console.ReadLine();
                Console.WriteLine("You Chose " + _breadType + ",  Do You Want to Order More? Press Y for Yes, and N for No");
                string yes = Console.ReadLine();
                bool answer = yes.Equals("Y", StringComparison.OrdinalIgnoreCase);
                while(answer == true)
                {
                    Console.WriteLine("What Type of Bread Would You Like?");
                    _breadType = Console.ReadLine();
                    Console.WriteLine("You Chose " + _breadType + ",  Do You Want to Order More? Press Y for Yes, and N for No");
                    string loopCheck = Console.ReadLine();
                   
                    if(loopCheck != yes)
                    {
                        break;
                    } else
                    {
                        i++;
                    }
                } 
            }   
             
        }
    }  
}
