// Задача 1: Напишите программу,
// которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

if (number.Length != 5)
{
    Console.WriteLine($"Введенное число не пятизначное");
}
else if (number[0] == number[4] && number[1] == number[3])
    Console.Write($"Введенное число является палиндромом");
else
    Console.Write($"Введенное число НЕ является палиндромом");