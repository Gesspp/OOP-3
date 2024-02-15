using System;
using System.ComponentModel.DataAnnotations;
using Arrays;

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