// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num<100 || num >=1000)
// {
// 	Console.WriteLine("Вы ввели неверное число. Введите трёхзначное число.");
// 	return;
// }
// Console.WriteLine("Введённое число " +num);
// int result = num / 10 % 10;
// Console.WriteLine("Вторая цифра " +result);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int ThirdRank(int num)
// {
// 	while (num > 999)
// 	{
// 	num /= 10;
// 	}
// return num % 10;
// }
// if (num < 100)
// {
// 	Console.WriteLine("Третьей цифры нет");
// 	return;
// }
// Console.WriteLine(ThirdRank(num));


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 7 || num < 1)
// {
// 	Console.WriteLine("Неверно. Введите число от 1 до 7");
// 	return;
// }
// if (num>=1 && num<=5)
// {
// 	Console.WriteLine("нет");
// }
// else
// {
// 	Console.WriteLine("да");
// }
