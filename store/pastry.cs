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
        private int _countOne;
        private int _countTwo;
        private int _countThree;
        private int _totalCost;

        public  PastryOrder()
        {
            _pastryOne = "Cherry Danishs";
            _pastryTwo = "Bear Claws";
            _pastryThree = "Jedi Pastries";
            _pastryType = "Cherry Danish";
            _costOne = 4;
            _costTwo = 5;
            _costThree = 501;
            _totalCost = 0;
            _countOne = 0;  
            _countTwo = 0;
            _countThree = 0; 
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

       
        private void OnStart()
        {
             Console.WriteLine("Here is our Exquisite Pastry Selection!: " + _pastryOne + " is " + _costOne + " Dollars, " + _pastryTwo + " is " + _costTwo + " Dollars, " + _pastryThree + " is " +  _costThree + " Dollars.." );
            int num = 1;
            
            for(int i = 0; i < num; i ++)
            {
                Console.WriteLine("What Type of pastry Would You Like? To Make it Simple for you Guys, Press 1 for White pastry, Press 2 for French pastry, or Press 3 for Jedi Pastry, Woahhhhh");
                string choice = Console.ReadLine();
                if(choice == "1")
                {
                    _pastryType = _pastryOne;
                    Console.WriteLine("How Many " + _pastryType +" Would You Like");
                     _countOne = int.Parse(Console.ReadLine());
                   
                } else if(choice == "2")
                {
                    _pastryType = _pastryTwo;
                    Console.WriteLine("How Many " + _pastryType +" Would You Like");
                    _countTwo = int.Parse(Console.ReadLine());
                   
                } else if( choice == "3")
                {
                    _pastryType = _pastryThree;
                    Console.WriteLine("How Many " + _pastryType +" Would You Like");
                    _countThree = int.Parse(Console.ReadLine());
                   
                } else
                {
                    Console.WriteLine("We Dont Have That pastry Thanks for Checking for Errors");
                }

                
                Console.WriteLine("Do You Want to Order More? Press Y for Yes, and N for No");
                string yes = Console.ReadLine();
                bool answer = yes.Equals("Y", StringComparison.OrdinalIgnoreCase);
                while(answer == true)
                {
                    Console.WriteLine("What Type of pastry Would You Like?");
                    string loopChoice = Console.ReadLine();
                    if(loopChoice == "1")
                    {
                        _pastryType = _pastryOne;
                         Console.WriteLine("How Many  " + _pastryType +" Would You Like");
                        _countOne = int.Parse(Console.ReadLine());
                       
                    } else if(loopChoice == "2")
                    {
                        _pastryType = _pastryTwo;
                        Console.WriteLine("How Many  " + _pastryType +" Would You Like");
                        _countTwo = int.Parse(Console.ReadLine());
                       
                    } else if( loopChoice == "3")
                    {
                        _pastryType = _pastryThree;
                        Console.WriteLine("How Many  " + _pastryType +" Would You Like");
                        _countThree = int.Parse(Console.ReadLine());
                    
                    } else
                    {
                        Console.WriteLine("We Dont Have That Pastry Thanks for Checking for Errors Again!!");
                    }

                    Console.WriteLine("Do You Want to Order More? Press Y for Yes, and N for No");
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
         private void TotalPrice()
        {
            
            int _totalCost = _countOne * _costOne + _countTwo * _costTwo + _countThree * _costThree;
            Console.WriteLine("Your Order Total so far is " + _totalCost + " Dollars");
        }
    }
}