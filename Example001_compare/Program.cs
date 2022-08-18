//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите два целых числа: "); //Даем пользователю возможность ввести числа
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b) Console.WriteLine(a + " больше " + b); //Сравниваем два числа
else Console.WriteLine(a + " меньше " + b);
