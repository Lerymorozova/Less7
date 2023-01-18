// Задайте двумерный массив размером m×n
//  заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rand.Next(-10, 10) + rand.NextDouble();


        Console.Write(array[i, j]. ToString(" 0.0 "));
    }

    Console.WriteLine() ;
}

// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 50);

        Console.Write($"{array[i, j]} ");

    }
    Console.WriteLine();
}

for (int j = 0; j < m; j++)
{
    int summa = 0;

    for (int i = 0; i < n; i++)
    {

        summa += array[i, j];

    }
    Console.Write($" Сумма {summa} ");
    Console.WriteLine($" Среднее арифметическое {summa / n} ");
}



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 50);

        Console.Write($"{array[i, j]} ");

    }
    Console.WriteLine();
}
Console.WriteLine("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
try
{
    Console.WriteLine($" Значение {array[x, y]} ");
}
catch
{
    Console.WriteLine("Такого элемента нет");
}

// Почему-то у меня не работает конструкция  if/else
// if (x > m && y > n)
// {
 
//    Console.WriteLine("Такого элемента нет");
// }
// else 
// { 
//     Console.WriteLine($" Значение {array[x, y]} ");
// }