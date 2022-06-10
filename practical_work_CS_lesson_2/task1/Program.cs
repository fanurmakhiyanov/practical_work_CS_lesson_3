// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

int[] array = new int[5];
int index = array.Length - 1;

while (numberInt > 0)
{
    array
        [index] = numberInt % 10;
        numberInt = numberInt / 10;
        index--;
}

    printArray(array);