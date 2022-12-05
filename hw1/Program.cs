/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

 */

Console.WriteLine("Enter number");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int hundreds = number % 100;
int secondNumber = hundreds / 10; 

Console.WriteLine($"Result is {secondNumber}");


