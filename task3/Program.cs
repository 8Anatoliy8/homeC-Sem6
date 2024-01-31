// // Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool IsStringPalindrom(string str)
{
    str = str.ToLower();
    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
    {
        if (str[i] != str[j])
        {
            return false;
        }
    }
    return true;
}

Console.Write("Введите строку для проверки палидрома: ");
string inputString = Console.ReadLine();

if (IsStringPalindrom(inputString))
{
    Console.Write("Введенная строка является палидромом");
}
else
{
    Console.Write("Введенная строка не является палидромом");
}