using System.Runtime.ExceptionServices;

Console.WriteLine("введите номер");
var TripleA = Convert.ToDouble(Console.ReadLine());
if (TripleA == 1)
{
    int DUB = 0;
    for (int a = 10; a < 100; a++)
    {
        DUB += a * a * a;
    }
    Console.WriteLine(DUB);
}
else if (TripleA == 2)
{
    Console.WriteLine("x y");
    for (int x = 2; x <= 12; x += 2)
    {
        Console.WriteLine($"{x} {Math.Pow(x, 3) + 3}");
    }
}
else if (TripleA == 3)
{
    Console.WriteLine("x y");
    for (var x = Convert.ToDouble(-3); x <= 3; x += 0.5)
    {
        Console.WriteLine($"{x} {x * 3 + 9}");
    }
}
else if (TripleA == 4)
{
    for (int x = 10; x <= 30; x++)
    {
        Console.WriteLine(Math.Pow(x, 2));
    }
}
else if (TripleA == 5)
{

}
else if (TripleA == 6)
{
    int b = 0;
    for (int x = 1; x <= 20; x++)
    {
        b += x * x;
    }
    Console.WriteLine(b);
}
else if (TripleA == 7)
{
    Console.WriteLine("введите N");
    int xyx = (int)Convert.ToDouble(Console.ReadLine());
    int b = 1;
    for (int i = 1; i <= xyx; i++)
    {
        b = b * i;
    }
    Console.WriteLine(b);
}
else if (TripleA == 8)
{
    for (int i = 1; i <= 50; i++)
    {
        Console.WriteLine($"{i} {Math.Pow(i, 2)}");
    }
}
else if (TripleA == 9)
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"9 * {i} = {i * 9}");
    }
}
else if (TripleA == 10)
{

}
else if (TripleA == 11)
{
    Console.WriteLine("U");
    for (var i = Convert.ToDouble(0);  i <= 10; i += 0.3)
    {
        Console.WriteLine(i + 1);
    }
}
else if (TripleA == 12)
{
    var xix = Convert.ToDouble(1);
    for (var i = 12; i <= 38; i++)
    {
        xix = xix * i;
    }
    Console.WriteLine(xix);
}