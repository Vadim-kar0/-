//Начало 

//Условные выражения 
// > - болше 
// >= - больше лтбо равно 
// < - мнешье 
// <= - меньше либо равно
// == - равно 
// != - Не равно 
//&& - логическое "И" (должны выполнятся все условия)
/* int x = 11;
if (x > 5 && x < 10)
{
    Console.WriteLine("Win!");

}
else
{
    Console.WriteLine("Win, but another");
}
 */

//|| - логическое "ИЛИ" (должны выполнятся все условия)
/* int x = 11;
if (x == 5 || x < 10)
{
    Console.WriteLine("Win!");

}
else
{
    Console.WriteLine("Win, but another");
}


 //! - логическое "НЕ" (если было тру станет фалс и наоборот)
int x = 11;
if (!(x > 5))
// {
//     Console.WriteLine("Win!");

// }
// else
// {
//     Console.WriteLine("Win, but another");
// }
 



//  int randomNumber = new Random().Next(10, 20); // от 10 до 19 включительно
//  Console.WriteLine(randomNumber);



/* Операции с числами 
% - остаток от деления 
4 % / == 0
5 % 2 == 1 */

//Console.WriteLine(5 % 2);

// / - целая часть от деления ( для целых чисел) 
//или просто деление (для дробных чисел)
//4 / 2 == 2
//5 / 2 == 2

// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 100); // от 10 включительно до 100 НЕ включительно
// Console.WriteLine("Случайное число: " + number);
// int first = number / 10; // 45 / 10 == 4
// int second = number % 10; // 45 % 10 == 5
// if (first > second)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + first);
// }
// if (second > first)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + second);
// }
// if (first == second)
// {
//     Console.WriteLine("Цифры числа равны");

// Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98

// int number = new Random().Next(100, 1000); 
// Console.WriteLine("Случайное число: " + number);
// int first = number / 100;
// int second = number % 10;
// Console.WriteLine("Число без средней цифры");
// Console.Write(first);
// Console.Write(second); 
