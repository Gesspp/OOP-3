using System;
using System.ComponentModel.DataAnnotations;

namespace Arrays;

sealed internal class odArray : bArray, ILineArray
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

    public void ReCreate(int length) {
        array = new int[length];
        userArray();
    }

    public override void userArray()
    {
        Console.WriteLine("Введите значения массива:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public override void randomArray()
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }
    }

    public override void Print()
    {
        Console.WriteLine("Элементы массива:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public override double middle()
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