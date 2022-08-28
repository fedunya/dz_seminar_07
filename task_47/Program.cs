// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void PrintArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < 0) Console.Write($"{array[i, j].ToString("F2")} ");
            else Console.Write($" {array[i, j].ToString("F2")} ");
        }
        Console.WriteLine();
    }
}
double[,] FillArrayRandom(int m, int n)
{
    double[,] result = new double[m, n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.NextDouble() * 20 - 10;
        }
    }
    return result;
}
int IntParseInput(string str)
{
ReadInput:
    Console.Write(str);
    var inputStringA = Console.ReadLine()!;
    if (!int.TryParse(inputStringA, out int num))
    {
        Console.WriteLine("Введено не число!");
        goto ReadInput;
    }
    else return num;
}

Console.Clear();
int m = IntParseInput("Введите число строк (m): ");
int n = IntParseInput("Введите число столбцов (n): ");
PrintArray(FillArrayRandom(m, n));
