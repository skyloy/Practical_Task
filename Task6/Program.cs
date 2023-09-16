// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"{num} is even number"); // чётное
}
else
{
    Console.WriteLine($"{num} is odd number"); // нечётное
}