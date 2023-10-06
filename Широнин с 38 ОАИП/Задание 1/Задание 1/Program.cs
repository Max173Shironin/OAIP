Console.WriteLine("введите последовательность чисел через пробел");
var x = Console.ReadLine();
string[] n= x.Split(' ');
int b = 0;
foreach (var z in n)
{
    var zz = Convert.ToInt32(z);
    b += zz;
}
Console.WriteLine(b);