//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три целых числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    if (a > c) Console.WriteLine("Наибольшее число " + a);
    else Console.WriteLine("Наибольшее число " + c);
}
else 
{
    if (b > c) Console.WriteLine("Наибольшее число " + b);
    else Console.WriteLine("Наибольшее число " + c);
}