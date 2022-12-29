// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
System.Console.WriteLine("Введите размер массива m x n");
int m = inputNumber("m = ");
int n = inputNumber("n = ");
int[,] Array = FillArrayAndPrint(m, n);
System.Console.WriteLine();
ChangeArray(Array);




void ChangeArray(int[,] Array)
{
    // int [,] NewArray = new int[m,n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int a = 0; a < Array.GetLength(1); a++)
        {
            int Z = 0;
            int max = Array[i, a];
            for (int j = a; j < Array.GetLength(1); j++)
            {
                if (Array[i, j] > max)
                {
                    max = Array[i, j];
                    Z = j;
                }
            }
            int temp = Array[i, a];
            Array[i, a] = max;
            Array[i, Z] = temp;
            System.Console.Write(Array[i, a] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[,] FillArrayAndPrint(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 10);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    return array;
}


int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}


