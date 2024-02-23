using System;
using Arrays;

class Printer : iPrinter {
    public void Print() {
        string[] weekdays = {"Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье"};

        foreach (string day in weekdays) {
            Console.Write(day + " ");
        }
        
    }
}