using System;
namespace Arrays;

sealed internal class tdArray : bArray, ITDArray
{
    public int[,] array;

    public tdArray(int rows, int columns, bool fillByUser = false)
    {
        array = new int[rows, columns];
        if (fillByUser)
        {
            userArray();
        }
        else
        {
            randomArray();
        }
    }

    public override void userArray()
    {
        Console.WriteLine("Введите значения матрицы:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToInt32(values[j]);
            }
        }
    }

    public override void randomArray()
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }
    }

    public override void Print()
    {
        Console.WriteLine("Элементы матрицы:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public override double middle()
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
                count++;
            }
        }
        return (double)sum / count;
    }

    public void reverse()
    {
        Console.WriteLine("Элементы матрицы с четными строками в обратном порядке:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 1)
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
