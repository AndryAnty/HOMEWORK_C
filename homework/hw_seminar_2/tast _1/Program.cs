// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введитте трехзначное число");
string num = Console.ReadLine();
int two = int.Parse(num[1].ToString());

Console.WriteLine(two);

//int x = num / 100;
//x = x * 10;
//x = x + (num % 10);

//int result = (num / 100) * 10 + num % 10;

//Console.WriteLine($"its -> {x}");