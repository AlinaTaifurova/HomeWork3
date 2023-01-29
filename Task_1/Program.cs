/*Задача 1

Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является 
ли оно палиндромом. Не использовать строки
14212 -> нет
12821 -> да
23432 -> да*/

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int reversD(int num)
{
    int rev = 0;
    while (num > 0)
    {
        rev = rev * 10 + num % 10;
        num = num / 10;
    }
    return rev;
}
int number = Prompt("Введите число: ");
int reverse = reversD(number);
if (number == reverse)
{
    System.Console.WriteLine($"{reverse} - полиндром");
}
else
{
    System.Console.WriteLine($"{reverse} - не полиндром");
}