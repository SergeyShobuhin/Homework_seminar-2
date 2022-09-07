// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write ("Введите число соответствующее дню недели от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

void Number() 
    {
        if (num > 5 & num < 8) Console.WriteLine("да");
        else if (num > 0 & num <= 5) Console.WriteLine("нет");
        else Console.WriteLine($"{num} не соответствует дню недели");
    }

Number();