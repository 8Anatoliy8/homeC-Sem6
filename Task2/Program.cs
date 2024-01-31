// Задача 2: Задайте строку, 
// содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Write("Введите строку: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower();
Console.Write ($"Ваша строка в нижнем регистре: {inputString}");