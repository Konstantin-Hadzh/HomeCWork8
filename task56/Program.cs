/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] GenerateArray(int height, int weight, int deviation)
{
    int[,] genArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            genArray[i,j] = new Random().Next(deviation +1);
        }
    }
    return genArray; 
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void ShowArray(int[,] inputArray)
{
    printColorData($" \t"); // вертикальная маркировка строк
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t"); 
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t"); // горизонтальная маркировка столбцов
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j]}\t"); // \t - автотабуляция 
        }
        Console.WriteLine();
    }
}

void NumberRowMinSumElements(int[,] inputArray)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        minRow += inputArray[0, i];
    }
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++) sumRow += inputArray[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"{minSumRow + 1} строка с наименьшей суммой элементов");
}
Console.WriteLine();

int[,] genArray = GenerateArray(3, 5, 10);
ShowArray(genArray);
NumberRowMinSumElements(genArray);
Console.WriteLine();