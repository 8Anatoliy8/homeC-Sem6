// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

string GetStringFromCharArrayMatrix (char [,] charMatrix)
{
    string result = string.Empty;
    for (int i = 0; i < charMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < charMatrix.GetLength(1); j++)
        {
            result += charMatrix[i,j];
        }
    }
    return result;
}

char [,] charsMatrix = {{'H', 'e', 'l', 'l', 'o', }, {'W', 'o', 'r', 'l', 'd'}};
string result = GetStringFromCharArrayMatrix (charsMatrix);
Console.WriteLine($"Результат: {result}");