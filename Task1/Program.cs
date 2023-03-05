Console.Clear();
Console.Write("Введите 1-е число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int n = int.Parse(Console.ReadLine()!);
if (m > n)
    Console.WriteLine($"max = {m}");
else
    Console.WriteLine($"max = {n}");