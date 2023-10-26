string type = Console.ReadLine();

switch (type)
{
    case "int":
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(CompareInts(num1, num2));
            break;
        }

    case "char":
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());

            Console.WriteLine(CompareChars(ch1, ch2));
            break;
        }

    case "string":
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(CompareStrings(str1, str2));
            break;
        }
}

static string CompareStrings(string str1, string str2)
{
    if (string.Compare(str1, str2) > 0)
    {
        return str1;
    }
    else return str2;
}

static char CompareChars(char ch1, char ch2)
{
    if (ch1 > ch2)
    {
        return ch1;
    }
    else return ch2;
}

static int CompareInts(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    else return num2;
}