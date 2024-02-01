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