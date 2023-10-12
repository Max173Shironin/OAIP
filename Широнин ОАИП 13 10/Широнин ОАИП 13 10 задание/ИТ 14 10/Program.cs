Console.WriteLine("Широнин Максим ИСП.22А ИТ 14.10 Решение варианта задания 4");
double a = 1.1;
double a1 = 1.6;
double Y = 0; double Y1 = 0;
for (double x = 0; x <= 5; x += 0.5)
{
    Y = (a * x + Math.Log(1.0 + a * x)) / (1.0 + Math.Pow(a * x, 2));
    Y1 = (a1 * x + Math.Log(1.0 + a1 * x)) / (1.0 + Math.Pow(a1 * x, 2));
    Console.WriteLine($"При a = 1.1, 1.6 и x = {x} ;\n " +
    $"{a} * {x} + {Math.Round(Math.Log(1 + a1 * x),2)}/{1.0} + {Math.Round(Math.Pow((a * x), 2), 2)} = {Math.Round(Y, 2)} \n " +
    $"{a1} * {x} + {Math.Round(Math.Log(1 + a1 * x), 2)}/{1.0} + {Math.Round(Math.Pow((a1 * x), 2), 2)} = {Math.Round(Y1, 2)}");
}
Console.ReadLine();
