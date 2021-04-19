namespace Task2
{
    //2. Написать программу "Конвертор валют". Программа должна поддерживать не менее 5 валют, Конвертация должна быть доступна из любой валюты в любую.
    //Пару валют и сумму для конвертации указывает пользователь.Rate валют можете брать тот, что сейчас на текущий момент, 
    //решить с использованием классов, предусмотреть все негативные кейсы, не нужно использовать реальные rates в runtime!)
    internal partial class Program
    {
        public static string _userAction;
        static void Main(string[] args)
        {
            var exchangeRates = new ExchangeRates();

            while (_userAction!="e")
            {
                exchangeRates.ChooseCurrency();   
                
            }

        }
    }
}
