/*
Задача 54. Задайте двухмерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двухмерного массива
*/


int[,] GenerateArray(int height, int weight)
{
    int[,] genArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            genArray[i,j] = new Random().Next(1, 10);
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

void GetSortNumLineArray(int[,] inputArray) // функция упорядовачивания элементов в строках
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
            {
                if (inputArray[i, k] < inputArray[i, k + 1])
                {
                    int temp = inputArray[i, k + 1];
                    inputArray[i, k + 1] = inputArray[i, k];
                    inputArray[i, k] = temp;
                }
            }
        }
    }
}

int[,] genArray = GenerateArray(3, 5);
ShowArray(genArray);
Console.WriteLine();
GetSortNumLineArray(genArray);
ShowArray(genArray);
