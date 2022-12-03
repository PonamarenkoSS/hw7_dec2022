// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(rows, columns);
// PrintArray(array);

// double[,] GetArray(int m, int n){
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = (new Random().NextDouble())*10;
//         }
//     }
//     return result;
// }

// void PrintArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]:f2} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9

int rows = new Random().Next(0,11);
int columns = new Random().Next(0,11);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите номер строки для вывода элемента: ");
int checkRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца для вывода элемента: ");
int checkColumn = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Check(checkRow, checkColumn, array);

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Check(int m, int n, int[,] array)
{
    if (m < array.GetLength(0) && n < array.GetLength(1))
    {
        Console.WriteLine($"Элемент массива с заданными индексами строки и столбца - {array[m,n]}");
    }
    else 
    {
        Console.WriteLine($"Такого элемента в массиве нет");
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// AverageColumns(array);

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void AverageColumns(int[,] array)
// {
//     string text = "Среднее арифметическое каждого столбца: ";
//     double avg = 0;
//     double sum = 0;
//     for (int j=0; j < array.GetLength(1); j++)
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             sum = sum + array[i,j];
//         }
//         avg = Math.Round(sum/array.GetLength(1), 1);
//         text = text + avg + "; ";
//         sum = 0;
//     }
//     text = text.Substring(0, text.Length - 2) + ".";
//     Console.WriteLine(text);
// }

