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


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число A: ");
// int A = int.Parse(Console.ReadLine());

// Console.Write("Введите степень B: ");
// int B = int.Parse(Console.ReadLine());

// int result = 1;

// for (int i = 0; i < B; i++)
// {
//     result *= A;
// }
// Console.WriteLine($"{A}^{B} = {result}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int sum = 0;

// while (number > 0)
// {
//     sum += number % 10;
//     number /= 10;
// }
// Console.WriteLine($"Сумма цифр в числе: {sum}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] array = new int[8];

//     for (int i = 0; i < 8; i++)
//     {
//         Console.Write($"Введите элемент {i + 1}: ");
//         array[i] = int.Parse(Console.ReadLine());
//     }
// Console.WriteLine("[" + string.Join(", ", array) + "]");
