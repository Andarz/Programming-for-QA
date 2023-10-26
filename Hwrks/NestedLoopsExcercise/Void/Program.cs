namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double needMoneyVacation = double.Parse(Console.ReadLine());
            double avaiableMoney = Math.Abs(double.Parse(Console.ReadLine()));
            string actionType = Console.ReadLine();
            double saveOrSaveMoneyAmount = double.Parse(Console.ReadLine());

            int daySpendConsecutive = 0;

            int days = 0;

            while (avaiableMoney <= needMoneyVacation)
            {
                if (actionType == "spend")
                {
                    avaiableMoney -= saveOrSaveMoneyAmount;
                    daySpendConsecutive++;
                    days++;
                    if (daySpendConsecutive >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{daySpendConsecutive}");
                        return;
                    }
                    else if (avaiableMoney < 0)
                    {
                        avaiableMoney = 0;
                    }
                    else if (avaiableMoney >= needMoneyVacation)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }

                }
                if (actionType == "save")
                {
                    avaiableMoney += saveOrSaveMoneyAmount;
                    days++;
                    if (avaiableMoney >= needMoneyVacation)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }
                actionType = Console.ReadLine();
                saveOrSaveMoneyAmount = double.Parse(Console.ReadLine());
            }
        }
    }
}
