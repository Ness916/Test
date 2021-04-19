using System;

namespace Task2
{
    internal partial class Program
    {
        public class ExchangeRates
        {
            public void ChooseCurrency()
            {
                double _amount = 0;
                double _result = 0;


                Console.WriteLine("The company welcomes you! Please enter amount");
                try
                {
                    _amount = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine($"incorrect input format{_amount}");
                }
               
                Console.WriteLine("Please select your currency to exchange:\n(U) USD- US Dollar, (E) EUR- Euro, (G) GBP- British Pound, (UA) UAH- Ukranian hryvnia, (R) Rub- Russian ruble");
                var userOperation = Console.ReadLine();

                switch (userOperation?.ToLower())
                {
                    case "u": _result = _amount * 1; Console.WriteLine($"You enter {_amount} USD."); break;
                    case "e": _result = _amount * 1.1795; Console.WriteLine($"You enter {_amount} EUR"); break;
                    case "g": _result = _amount * 1.3897; Console.WriteLine($"You enter {_amount} GBP"); break;
                    case "ua": _result = _amount * 0.0358; Console.WriteLine($"You enter {_amount} UAH"); break;
                    case "r": _result = _amount * 0.0131; Console.WriteLine($"You enter {_amount} RUB"); break;
                    default: Console.WriteLine($"Invalid operation {userOperation}."); break;
        
                }
           
                Console.WriteLine("Please indicate the currency for exchange:\n(U) USD- US Dollar, (E) EUR- Euro, (G) GBP- British Pound, (UA) UAH- Ukranian hryvnia, (R) Rub- Russian ruble");
                var userChoise = Console.ReadLine();
                double resultOfExchange = 0;

                switch (userChoise?.ToLower())
                {
                    case "u": resultOfExchange = _result * 1; resultOfExchange = Math.Round(resultOfExchange, 1); Console.WriteLine($"You chose to convert to US Dollar, {resultOfExchange} USD "); break;
                    case "e": resultOfExchange = _result * 0.8472; resultOfExchange = Math.Round(resultOfExchange, 1); Console.WriteLine($"You chose to convert to Euro, {resultOfExchange} Euro"); break;
                    case "g": resultOfExchange = _result * 0.7194; resultOfExchange = Math.Round(resultOfExchange, 1); Console.WriteLine($"You chose to convert to GBP, {resultOfExchange} GBP"); break;
                    case "ua": resultOfExchange = _result * 27.8511; resultOfExchange = Math.Round(resultOfExchange, 1); Console.WriteLine($"You chose to convert to UAH, {resultOfExchange} UAH"); break;
                    case "r": resultOfExchange = _result * 76.1220; resultOfExchange = Math.Round(resultOfExchange, 1); Console.WriteLine($"You chose to convert to RUB, {resultOfExchange} RUB"); break;
                    default: Console.WriteLine($"Invalid operation {userOperation}."); break;
                }

                Console.WriteLine("Do you want to continue (С) or exit (E)");
                _userAction = Console.ReadLine();
                switch (_userAction?.ToLower())
                {
                    case "c": ChooseCurrency(); break;
                    case "e": break;
                    default: Console.WriteLine($"Invalid operation {userOperation}."); break;
                }
            }

        }
    }
}
