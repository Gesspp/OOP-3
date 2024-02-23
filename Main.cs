using System;
using System.ComponentModel.DataAnnotations;
using Arrays;

public class Program
{
    public static void Main(string[] args)
    {
        IBaseArray[] arrays = new IBaseArray[3];
        Console.WriteLine("Сколько элементов будет в одномерном массиве?");
        int odLength = int.Parse(Console.ReadLine());
        arrays[0] = new odArray(odLength, true);

        Console.WriteLine("Сколько строк будет в двумерном массиве?");
        int tdStroke = int.Parse(Console.ReadLine());
        Console.WriteLine("Сколько колонок будет в двумерном массиве?");
        int tdColumns = int.Parse(Console.ReadLine());
        arrays[1] = new tdArray(tdStroke, tdColumns);

        Console.WriteLine("Введите столько цифр(на разных строчках), сколько будет строчек и значения этих цифр будут колличество элементов в строке");
        int[] rows = new int[3];
        
        for (int i = 0; i < 3; i++) {
            rows[i] = int.Parse(Console.ReadLine());
        }

        arrays[2] = new JaggedArray(new int[] { rows[0], rows[1], rows[2] }, true);

        for (int i = 0; i < arrays.Length; i++) {
            arrays[i].Print();

            Console.WriteLine($"Среднее - {arrays[i].middle()}");

        }

        Printer weekdays = new Printer();

        iPrinter[] printable = new iPrinter[4];
        
        printable[0] = arrays[0];
        printable[1] = arrays[1];
        printable[2] = arrays[2];
        printable[3] = weekdays;

        for (int i = 0; i < printable.Length; i++) {
            printable[i].Print();

            Console.WriteLine(printable[i]);

        }

    }
}