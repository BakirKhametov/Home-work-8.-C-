// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] array = new int[4, 4];
SpiralArray(array);
PrintSpiralArray(array);

void SpiralArray(int[,] array)
{
    int n = 4;
    int m = 4;
    int iStart = 0;
    int iFinish = 0;
    int jStart = 0;
    int jFinish = 0;
    int numberArray = 1;
    int i = 0;
    int j = 0;

    while (numberArray <= n * m)
    {
        array[i, j] = numberArray;
        if (i == iStart && j < m - jFinish - 1)
            ++j;
        else if (j == m - jFinish - 1 && i < n - iFinish - 1)
            ++i;
        else if (i == n - iFinish - 1 && j > jStart)
            --j;
        else
            --i;

        if ((i == iStart + 1) && (j == jStart) && (jStart != m - jFinish - 1))
        {
            ++iStart;
            ++iFinish;
            ++jStart;
            ++jFinish;
        }
        ++numberArray;
    }
}
void PrintSpiralArray(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); ++x)
    {
        for (int y = 0; y < array.GetLength(1); ++y)
        {
            if (array[x, y] < 10)
            {
                Console.Write($"0{array[x, y]} | ");
            }
            else
            {
                Console.Write($"{array[x, y]} | ");
            }
        }
        Console.WriteLine(); ;
    }
}

