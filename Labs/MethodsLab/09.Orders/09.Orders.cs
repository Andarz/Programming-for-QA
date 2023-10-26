string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double totalPrice = CountAndPrintTotal(product, quantity);

Console.WriteLine($"{totalPrice:f2}");

double CountAndPrintTotal(string product, int quantity)
{
    double totalPrice = 0;

    switch (product)
    {
        case "coffee":
            totalPrice = quantity * 1.5;
            break;
        case "water":
            totalPrice = quantity * 1.0;
            break;
        case "coke":
            totalPrice = quantity * 1.4;
            break;
        case "snacks":
            totalPrice = quantity * 2.0;
            break;

    }
    return totalPrice;
}