﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задаём число
Console.Write ("Введите число ");
int num = int.Parse(Console.ReadLine());

// Задаём функцию
void Number() 
    {
        // Блок проверки на количество цифр, не менее 3 символов
        if (num < 100) 
            {
                Console.WriteLine("третьей цифры нет");
                return;
            }

        // Блок определния третьей цифры  
        while (num > 1000)
            {
                num = num / 10; 
            }
                num = num % 10;
                Console.WriteLine(num);
    }

Number();
