// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задаём число
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
int numTwo;

// Задаём функцию
void Number() 
    {
        do 
            {
                num = num / 10;    
                    if(num < 100 & num > 10) 
                        {       
                            numTwo = num % 10;
                            Console.WriteLine(numTwo);
                        }
                    else break;
            }
        while (num > 100);
    }
Number();