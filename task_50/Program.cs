// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

void PrintArray(int[,] array) {
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
            result[i,j] = random.Next(10, 100);
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
void ReturnValueElement(int[,] array, int m, int n) {
    if(m >= array.GetLength(0) || n >= array.GetLength(1)) {
        Console.WriteLine("Такого элемента в массиве нет!");
    }
    else {
        Console.WriteLine(array[m, n]);
    } 
}

Console.Clear();
int m = IntParseInput("Введите число строк массива (m): ");
int n = IntParseInput("Введите число столбцов массива (n): ");
var result = FillArrayRandom(m, n);
PrintArray(result);
Console.WriteLine();
int lineArray = IntParseInput("Введите номер строки элемента: ");
int columnArray = IntParseInput("Введите номер столбца элемента: ");
ReturnValueElement(result, lineArray, columnArray);


