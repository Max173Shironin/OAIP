Console.WriteLine("введите последовательность чисел через пробел");
var a = Console.ReadLine();
string[] da = a.Split(' ');
int b = 0;
foreach (var i in da)
{
    var ii = Convert.ToInt32(i);
    b *= ii;
}
Console.WriteLine(b);