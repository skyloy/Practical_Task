// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input 1st number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2nd number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 3nd number:");
int num3 = Convert.ToInt32(Console.ReadLine());

int[] array = {num1, num2, num3};
Console.Write(array.Max() + " is max number");
