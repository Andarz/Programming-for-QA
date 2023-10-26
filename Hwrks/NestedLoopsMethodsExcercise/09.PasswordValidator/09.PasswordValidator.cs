string password = Console.ReadLine();

bool isValidLength = password.Length >= 6 && password.Length <= 10;

bool isValidContent = CheckContent(password);

bool isValidDigitCount = CheckDigitsCount(password);

if (isValidLength == true
    && isValidContent == true
    && isValidDigitCount == true)
{
    Console.WriteLine("Password is valid");
}
else
{
    if (isValidLength == false)
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    if (isValidContent == false)
    {
        Console.WriteLine("Password must consist only of letters and digits");
    }
    if (isValidDigitCount == false)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
}


static bool CheckContent(string password)
{
    foreach (char ch in password)
    {
        if (char.IsLetterOrDigit(ch) == false)
        {
            return false;
        }
    }
    return true;
}

static bool CheckDigitsCount(string password)
{
    int count = 0;
    foreach (char ch in password)
    {
        if (char.IsDigit(ch))
        {
            count++;
        }
    }
    return count >= 2;
}