/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

Console.WriteLine("enter a number from 1 to 7");
string dayNumber = Console.ReadLine();

if (dayNumber == "1") Console.WriteLine("not a day off");
else if (dayNumber == "2") Console.WriteLine("not a day off");
else if (dayNumber == "3") Console.WriteLine("not a day off");
else if (dayNumber == "4") Console.WriteLine("not a day off");
else if (dayNumber == "5") Console.WriteLine("not a day off");

else if (dayNumber == "6" || dayNumber == "7") Console.WriteLine("This day is a day off");
else Console.WriteLine("invalid number");