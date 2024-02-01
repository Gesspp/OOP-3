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