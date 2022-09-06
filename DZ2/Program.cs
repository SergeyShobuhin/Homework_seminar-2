// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write ("Введите число ");
int num = int.Parse(Console.ReadLine());
int numTwo;
int numThree;
// numTwo = num % 10;                ////  РЕШЕНИЕ
// Console.WriteLine(numTwo);      ////
if (num < 99)
{
    // numTwo = num % 10;
    Console.WriteLine("третьей цифры нет");
}   
else
{
    numTwo = num % 10;
    Console.WriteLine(numTwo);
}


// while (num > 100 & num !=0)
//     {
//         // num = num / 100;
        // numTwo = num % 100;
        // numThree = num % 10; /// третье число
        // // Console.WriteLine(numTwo);
        // Console.WriteLine(numThree);
    // }
// void Number() 
//     {
//         // do 
//         //     {
//                 num = num % 10;  
//                   numTwo = num;
//                     // if(num < 1000 & num !=0) /// не могу придумать, как сделать так, что бы функция возвращалась если введено 2 числа
//                     //     {       
//                     //         // numTwo = num % 10;
//                             Console.WriteLine(numTwo);
//                             Console.WriteLine(num);
//                         // }
//                     // else break;
//         //     }
//         // while (num > 1000);
//     }
//     // Console.WriteLine(numTwo);
//                             // Console.WriteLine(num);
// Number();
     
// void Number() 
//     {
//         do 
//             {
//                 num = num / 100;    
//                     if(num < 1000 & num !=0) /// не могу придумать, как сделать так, что бы функция возвращалась если введено 2 числа
//                         {       
//                             numTwo = num % 10;
//                             Console.WriteLine(numTwo);
//                         }
//                     else break;
//             }
//         while (num > 100);
//     }
// Number();