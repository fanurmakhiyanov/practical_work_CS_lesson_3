// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).

void PrintArray()
{
    int[] myArray  = new int[8];
    int i = 0;
    for (i = 0; i < 8; i++)
    {
        Random chaotic = new Random();
        myArray[i] = chaotic.Next(10,100);
        Console.Write($"{myArray[i]}, " );
    }
}

PrintArray();