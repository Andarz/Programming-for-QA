namespace _09.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figType = Console.ReadLine();
            double area = 0;

            switch (figType)
            {
                case "square": 
                    double side = double.Parse(Console.ReadLine());
                    area = side * side;
                    Console.WriteLine("{0:f2}", area); break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = width * height;
                    Console.WriteLine("{0:f2}", area); break;
                case "circle":
                    double rad = double.Parse(Console.ReadLine());
                    area = Math.PI * rad * rad;
                    Console.WriteLine("{0:f2}", area); break;
                    
                default: Console.WriteLine("Invalid figure."); break;
            }
        }
    }
}