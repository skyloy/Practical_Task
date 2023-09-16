// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input 1st number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2nd number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Max is {num1}, Min is {num2} ");
}
else
{
    Console.WriteLine($"Max number is {num2}, Min number is {num1} ");
}