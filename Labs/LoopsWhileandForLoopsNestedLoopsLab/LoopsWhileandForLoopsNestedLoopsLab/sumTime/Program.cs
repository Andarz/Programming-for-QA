namespace sumTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double excCost = double.Parse(Console.ReadLine());
            int puzz = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzPrice = puzz * 2.60;
            double dollsPrice = dolls * 3;
            double bearsPrice = bears * 4.10;
            double minPrice = min * 8.20;
            double trucksPrice = trucks * 2;

            int totalToys = puzz + dolls + bears + min + trucks;
            double totalPrice = puzzPrice + dollsPrice + bearsPrice + minPrice + trucksPrice;

            double lihva = 0.0;

            if (totalToys >= 50)
            {
                lihva = totalPrice * 0.25;
                totalPrice = totalPrice - lihva;
            }
            if (lihva > 0)
            {
                lihva = totalPrice * 0.9;
            }
            if (lihva >= excCost)
            {
                Console.WriteLine($"Yes! {(lihva - excCost):f2} lv left.");
            }
            else
                Console.WriteLine($"Not enough money! {(excCost - lihva):f2} lv needed.");
            
        }
    }
}