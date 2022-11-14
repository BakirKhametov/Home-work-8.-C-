// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

int[,] array = new int[5, 4];
NewArray(array);
PrintArray(array);
Console.WriteLine();
MinSumNumberLine(array);


int[,] NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}
void MinSumNumberLine(int[,] arr)
{
    int indexFirstRow = 0;
    int firstRowSum = 0;
    int index = 0;
    int sumNumbersRow = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        firstRowSum += arr[indexFirstRow, j];
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            sumNumbersRow += arr[i, j];
            Console.WriteLine($"Сумма элементов строки - {sumNumbersRow} ");
            
        if (sumNumbersRow < firstRowSum)
        {
            firstRowSum = sumNumbersRow;
            index = i;
        }
        sumNumbersRow = 0;
    }
    Console.WriteLine();
    Console.Write($"Номер строки с наименьшей суммой элементов - {index + 1} ");  
}





