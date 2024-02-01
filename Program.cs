using System;
using System.ComponentModel.DataAnnotations;

public class odArray
{
    private int[] array;

    public odArray(int length, bool fillByUser = false)
    {
        array = new int[length];
        if (fillByUser)
        {
            userArray();
        }
        else
        {
            randomArray();
        }
    }

    private void userArray()
    {
        Console.WriteLine("Введите значения массива:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    private void randomArray()
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }
    }

    public void PrintArray()
    {
        Console.WriteLine("Элементы массива:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public double middle()
    {
        int sum = 0;
        foreach (int element in array)
        {
            sum += element;
        }
        return (double)sum / array.Length;
    }

    public void remove100()
    {
        int[] newArray = new int[array.Length];
        int newIndex = 0;
        foreach (int element in array)
        {
            if (Math.Abs(element) <= 100)
            {
                newArray[newIndex] = element;
                newIndex++;
            }
        }
        Array.Resize(ref newArray, newIndex);
        array = newArray;
    }

    public void removeRepeat()
    {
        int[] newArray = new int[array.Length];
        int newIndex = 0;
        foreach (int element in array)
        {
            if (Array.IndexOf(newArray, element) == -1)
            {
                newArray[newIndex] = element;
                newIndex++;
            }
        }
        Array.Resize(ref newArray, newIndex);
        array = newArray;
    }
}

public class tdArray
{
    private int[,] array;

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

    private void userArray()
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

    private void randomArray()
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

    public void PrintArray()
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

    public double middle()
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

    public int CalculateDeterminant()
    {
        if (array.GetLength(0) != array.GetLength(1))
        {
            throw new Exception("Матрица должна быть квадратной");
        }

        // Расчет определителя матрицы
        // Ваш код для расчета определителя
        return 0;
    }
}

public class JaggedArray
{
    private int[][] array;

    public JaggedArray(int[] lengths, bool fillByUser = false)
    {
        array = new int[lengths.Length][];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new int[lengths[i]];
        }

        if (fillByUser)
        {
            userArray();
        }
        else
        {
            randomArray();
        }
    }

    private void userArray()
    {
        Console.WriteLine("Введите значения ступенчатого массива:");
        for (int i = 0; i < array.Length; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = Convert.ToInt32(values[j]);
            }
        }
    }

    private void randomArray()
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = random.Next(1, 101);
            }
        }
    }

    public void PrintArray()
    {
        Console.WriteLine("Элементы ступенчатого массива:");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    public double middle()
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                sum += array[i][j];
                count++;
            }
        }
        return (double)sum / count;
    }

    public void middleInNested() {
        Console.Write("Средние значения во всех вложенных массивах");

        for (int i = 0; i < array.Length; i++) {
            int sum = 0;
            int cnt = 0;

            for (int j = 0; j < array[i].Length; j++) {
                sum += array[i][j];
                cnt++;
            }
            
            if (i < array.Length - 1) {
                Console.Write(" " + sum / cnt + ",");
            } else {
                Console.Write(" " + sum / cnt);
            }
        }
    }

    public void multy()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] % 2 == 0)
                {
                    array[i][j] = i * j;
                }
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Сколько элементов будет в одномерном массиве: ");
        int ODArrayLength = int.Parse(Console.ReadLine());
        odArray odArray = new odArray(ODArrayLength, true);
        odArray.PrintArray();
        Console.WriteLine("Среднее значение: " + odArray.middle());
        odArray.remove100();
        Console.WriteLine("массив без элементов больше 100 по модулю");
        odArray.PrintArray();
        odArray.removeRepeat();
        Console.WriteLine("массив без повторяющихся элементов");
        odArray.PrintArray();
        
        Console.WriteLine("Введите колличество строчек и столбцов(на разных строках)");
        int[] matRows = new int[2];

         for (int i = 0; i < 2; i++) {
            matRows[i] = int.Parse(Console.ReadLine());
        }

        tdArray tdArray = new tdArray(matRows[0], matRows[1], true);
        tdArray.PrintArray();
        Console.WriteLine("Среднее значение: " + tdArray.middle());
        tdArray.reverse();

        Console.WriteLine("Введите столько цифр(на разных строчках), сколько будет строчек и значения этих цифр будут колличество элементов в строке");
        int[] rows = new int[3];
        
        for (int i = 0; i < 3; i++) {
            rows[i] = int.Parse(Console.ReadLine());
        }

        JaggedArray jaggedArray = new JaggedArray(new int[] { rows[0], rows[1], rows[2] }, true);
        jaggedArray.PrintArray();
        Console.WriteLine("Среднее значение: " + jaggedArray.middle());
        jaggedArray.middleInNested();
        Console.WriteLine();
        jaggedArray.multy();
        jaggedArray.PrintArray();

        Console.ReadLine();
    }
}