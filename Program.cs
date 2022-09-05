Console.Clear();

//Нобходимые функции (не коммитить):
////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int[,] GetArray(int m, int n, int minValue, int maxValue) //функция заполнения рандомного двумерного массива с ЦЕЛЫМИ числами для всех задач 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void PrintArray(int[,] inArray) //функция отображения массива целых чисел
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}     ");
        }
        Console.WriteLine();
    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void SortedArray(int[,] array)    // функция сортировки строк массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j + 1; t < array.GetLength(1); t++)
            {
                if (array[i, t] > array[i, j])
                {
                    int temporary = array[i, j];
                    array[i, j] = array[i, t];
                    array[i, t] = temporary;
                }
            }
        }
    }
}


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Console.Write("Enter the rows number: ");
// int Rows = int.Parse(Console.ReadLine());

// Console.Write("Enter the columns number: ");
// int Columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(Rows, Columns, 0, 100);

// PrintArray(array);

// SortedArray(array);
// Console.WriteLine("Sortet array by Rowses: ");
// PrintArray(array);






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Enter the rows number: ");
// int Rows = int.Parse(Console.ReadLine());

// Console.Write("Enter the columns number: ");
// int Columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(Rows, Columns, 0, 10);

// PrintArray(array);

// int row = 0;
// int minSumm =0;
// for (int i = 0; i < array.GetLength(1); i++)
// {
//     minSumm += array[0,i];
// }
// for (int i = 1; i < array.GetLength(0); i++)
// {
//     int summ =0;
//     for (int j = 1; j < array.GetLength(1); j++)   
//     {
//     summ += array[i,j];  
//     }
//     if (minSumm > summ)
//     {
//         minSumm = summ;
//         row = i;
//     }
    
// }
// Console.WriteLine($"The number of less summ row's is: {row+1}"); //Вывел порядковый номер строки начиная с первого (0+1), для того, чтобы пользователь смог найти нужную строку без знания нумерации строк



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Write("Enter the first rows number: ");
int Rows1 = int.Parse(Console.ReadLine());

Console.Write("Enter the  first columns number: ");
int Columns1 = int.Parse(Console.ReadLine());

Console.Write("Enter the second rows number: ");
int Rows2 = int.Parse(Console.ReadLine());

Console.Write("Enter the  second columns number: ");
int Columns2 = int.Parse(Console.ReadLine());

    if (Columns1 !=  Rows2 )
    {
    Console.Write("Умножение невозможно, столбцы и строки должны быть равны: ");
    return;
    }

int[,] array1 = GetArray(Rows1, Columns1, 0, 10);
int[,] array2 = GetArray(Rows1, Columns1, 0, 10);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07