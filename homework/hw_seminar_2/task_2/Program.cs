// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите число");
string StNum = Console.ReadLine();
if (StNum.Length > 2)
{
    Console.WriteLine("Третья цифра: " + StNum[2]);
}
else
{
    Console.WriteLine("такой цифры нет");
}