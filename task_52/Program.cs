// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(double[] array) {
    for (var i = 0; i < array.Length; i++) {
        Console.Write($"{array[i].ToString("F2")}  ");
        }
    Console.WriteLine();
}
void Print2DArray(int[,] array) {
    for (var i = 0; i < array.GetLength(0); i++) {
        for (var j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] FillArrayRandom(int m, int n) {
    int[,] result = new int[m,n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++) {
        for (var j = 0; j < result.GetLength(1); j++) {
            result[i,j] = random.Next(1, 10);
        }
    }
    return result;
}
int IntParseInput(string str) {
ReadInput:
    Console.Write(str);
    var inputStringA = Console.ReadLine()!;
    if (!int.TryParse(inputStringA, out int num)) {
        Console.WriteLine("Введено не число!");
        goto ReadInput;
    }
    else return num;
}
double[] ArithmeticMeanColumns(int[,] array){
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        result[i] = (double)sum / (double)array.GetLength(0);
    }
    return result;
}

Console.Clear();
int m = IntParseInput("Введите число строк (m): ");
int n = IntParseInput("Введите число столбцов (n): ");
var result = FillArrayRandom(m, n);
Print2DArray(result);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
PrintArray(ArithmeticMeanColumns(result));
