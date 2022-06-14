// Задача 2: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Prompt("Введите X1 => ");
int y1 = Prompt("Введите Y1 => ");
int z1 = Prompt("Введите Z1 => ");

int x2 = Prompt("Введите X2 => ");
int y2 = Prompt("Введите Y2 => ");
int z2 = Prompt("Введите Z2=> ");

int a = x1 - x2;
int b = y1 - y2;
int c = z1 - z2;
double l = Math.Sqrt(a * a + b * b + c * c);

Console.WriteLine("Расстояние между двумя точками в 3D-пространстве: " + Math.Round(l, 3));