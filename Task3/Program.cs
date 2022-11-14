// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = new int[2, 2];
GetArray1(array1);
Console.WriteLine("Первая матрица");
PrintArray1(array1);
Console.WriteLine();
int[,] array2 = new int[2, 2];
GetArray2(array2);
Console.WriteLine("Вторая матрица");
PrintArray2(array2);
Console.WriteLine();
int[,] arrayProd = new int[2, 2];
ProductMatrix();
Console.WriteLine("Произведение двух матриц");
PrintArray3(arrayProd);

int[,] GetArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(1, 10);
        }
    }
    return array1;
}
void PrintArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} | ");
        }
        Console.WriteLine();
    }
}
int[,] GetArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(1, 10);
        }
    }
    return array2;
}
void PrintArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} | ");
        }
        Console.WriteLine();
    }
}
void ProductMatrix()
{
    for (int i = 0; i < arrayProd.GetLength(0); i++)
    {
        for (int j = 0; j < arrayProd.GetLength(1); j++)
        {
            for (int n = 0; n < array2.GetLength(0); n++)
            {
                arrayProd[i, j] += array1[i, n] * array2[n, j];
            }
            //Console.Write($"{arrayProd[i, j] + "|"} ");
        }
    }
}
void PrintArray3(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.Write($"{array3[i, j]} | ");
        }
        Console.WriteLine();
    }
}
