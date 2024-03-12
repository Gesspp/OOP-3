using System.ComponentModel.DataAnnotations;

namespace Arrays;

sealed internal class JaggedArray : bArray, IJaggedArray
{
    public int[][] array;

    public JaggedArray(int[] lengths, bool fillByUser = false) : base(fillByUser)
    {
        array = new int[lengths.Length][];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new int[lengths[i]];
        }


    }

    public void ReCreate(int[] lengths)
    {
        array = new int[lengths.Length][];
        userArray();
    }

    protected override void userArray()
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

    protected override void randomArray()
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

    public override void Print()
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

    public override double middle()
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

    public void middleInNested()
    {
        Console.Write("Средние значения во всех вложенных массивах");

        for (int i = 0; i < array.Length; i++)
        {
            int sum = 0;
            int cnt = 0;

            for (int j = 0; j < array[i].Length; j++)
            {
                sum += array[i][j];
                cnt++;
            }

            if (i < array.Length - 1)
            {
                Console.Write(" " + sum / cnt + ",");
            }
            else
            {
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
