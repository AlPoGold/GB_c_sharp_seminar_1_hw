// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine("Большее число: " + num1);
// }
// else
// {
//     Console.WriteLine("Большее число: " + num2);
// }

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int max = 0;
Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num1>max)
{
    max = num1;
}

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num2>max)
{
    max = num2;
}

Console.Write("Enter third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if(num3>max)
{
    max = num3;
}
Console.WriteLine("Максимальное из 3ех чисел: " + max);