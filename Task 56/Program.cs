// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
System.Console.WriteLine("Введите размер массива m x n");
int m = inputNumber("m = ");
int n = inputNumber("n = ");
int[,] Array = FillArrayAndPrint(m, n);
System.Console.WriteLine();
int a = 0;
int MinSum = 0;
System.Console.WriteLine();


for (int i = 0; i < Array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        sum += Array[i,j];
    }
    // System.Console.WriteLine(sum);
    if (i == 0)
    {
        MinSum = sum;
        a = i;
    }
    if (sum < MinSum)
        {
            MinSum = sum;
            // System.Console.WriteLine($"минимум сум {MinSum}");
            a = i;
        }
}
System.Console.WriteLine($"Наименьшая сумма элементов в строке № {a}");





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
