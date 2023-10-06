double k = 10;
double S = 0;
Console.WriteLine("Введите кол-во дней:");
int n = int.Parse(Console.ReadLine());
for (int x = 1; n-1 >= x; x++)
{
    k = 1.1 * k;
    S = S + k;
}
Console.WriteLine($"Суммарный путь {S}км");
