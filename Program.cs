// Задача 1: Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число =>");  // вывод пргилащшеня для ввода
string A = Console.ReadLine();   // ввод строки

int B = int.Parse(A);        // преобразуем строку в целое число

int last = B % 10;

int s = B - last;

int d = s /10;

int second = d % 10;


Console.WriteLine(second);
