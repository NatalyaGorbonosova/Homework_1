// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0) Console.WriteLine("Да, число " + a + " четное");
else Console.WriteLine("Нет, число " + a + " нечетное");
