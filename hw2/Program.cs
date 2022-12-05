/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

PS. Я гуглила такую штуку + result[..] - так как сама не догодалась :((
*/


Console.Write("Enter the number: ");

int number = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(number);

if (result.Length > 2)
{
  Console.WriteLine("third digit  " + result[2]);
}
else 
{
  Console.WriteLine("no third digit");
}
