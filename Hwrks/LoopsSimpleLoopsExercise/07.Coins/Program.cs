namespace _07.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int stotinki = (int)(input * 100);
            int coins = 0;
            int biggCoinValue = 200;

            while (stotinki / biggCoinValue != 0)
            {
                stotinki = stotinki - biggCoinValue;
                coins++;
            }

            while (stotinki >= 100)
            {
                biggCoinValue = 100;
                stotinki = stotinki - biggCoinValue;
                coins++;
            }

            while (stotinki >= 50)
            {
                biggCoinValue = 50;
                stotinki = stotinki - biggCoinValue;
                coins++;
            }

            while (stotinki >= 20)
            {
                biggCoinValue = 20;
                stotinki = stotinki - biggCoinValue;
                coins++;
            }

            while (stotinki >= 10)
            {
                biggCoinValue = 10;
                stotinki = stotinki - biggCoinValue;
                coins++;
            }

            while (stotinki >= 5)
            {
                biggCoinValue = 5;
                stotinki = stotinki - biggCoinValue;
                coins++;
            }

            while (stotinki >= 2)
            {
                biggCoinValue = 2;
                stotinki = stotinki - biggCoinValue;
                coins++;
            }

            while (stotinki >= 1)
            {
                biggCoinValue = 1;
                stotinki = stotinki - biggCoinValue;
                coins++;
            }

            Console.WriteLine(coins);
        }
    }
}