int A3 = 0; int A6 = 0; int A9 = 0; int A12 = 0; int A3n = 0; int x = 1;
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
for (int i = 1; n >= x; x++)
{
    i = i * 2;
    A3 = 1 * 2;
    A6 = 1 * 2 * 2;
    A9 = 1 * 2 * 2 * 2;
    A12 = 1 * 2 * 2 * 2 * 2;
    A3n = i;
}
Console.WriteLine($"{A3} амёбы за 3 часа; \n{A6} амёбы за 6 часов; \n{A9} амёб за 9 часов; \n{A12} амёб за 12 часов; \n{A3n} амёб за 3n часов");