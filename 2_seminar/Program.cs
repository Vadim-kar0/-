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



// Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число 
//не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

//  Console.WriteLine("Введите первое число");
// string text_a = Console.ReadLine();
// int a = Convert.ToInt32(text_a);
// Console.WriteLine("Введите второе число");
// string text_b = Console.ReadLine();
// int b = Convert.ToInt32(text_b);
// int sf = a % b;
// if( sf == 0)
// {
//    Console.Write(" кратно ");
// }

// if(sf != 0)
// {
//    Console.Write("Не кратно, остаток от деления : ");
//    Console.Write(sf);
// } 


// Задача 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да



Console.WriteLine("Введите число");
string text_a = Console.ReadLine();
int a = Convert.ToInt32(text_a);

if(a % 7 == 0 && a % 23 ==0)
{
     Console.Write("число кратно 7 и 23");
}
else
{
    Console.Write("число не кратно 7 и 23");
}









