﻿/*Задача 19 Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число ");
int a = Convert.ToInt32(Console.ReadLine());
//проверка на 5 значность
if (9999 < a && a < 100000)
{
    int a1 = a / 10000;
    int a5 = a % 10;
    int a2 = a / 1000 % 10;
    int a4 = a % 100 / 10;

    //Console.WriteLine($"{a1},{a2},{a4},{a5}"); смотрим, что насчитали

        if (a1 == a5 && a2 == a4)
        {
            Console.WriteLine("да, это палиндром!");
        }
         else
        {
            Console.WriteLine("это не палиндром! попробуйте снова");
        }
}  
else
{
Console.WriteLine("это не пятизначное число! попробуйте снова");
}
