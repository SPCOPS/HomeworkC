Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int ost = n % 2;
if (ost == 0)
Console.WriteLine("Да, число четное");
else
Console.WriteLine("Нет, число нечетное");