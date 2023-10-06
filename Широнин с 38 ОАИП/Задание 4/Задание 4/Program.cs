Console.WriteLine("Введите последовательность через пробел:");
var x = Console.ReadLine();
Console.WriteLine("Введите число для нахождения");
var y = Convert.ToInt32(Console.ReadLine());
string[] n = x.Split(' ');
int b = 0;
foreach (var z in n)
{
    var zz = Convert.ToInt32(z);
    if (zz == y) {b++;}
    Console.WriteLine(b);
}
