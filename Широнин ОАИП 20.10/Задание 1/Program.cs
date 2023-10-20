A:
Console.WriteLine("-------------------------------\nДоступные страницы: 33, 36, 38, 41, 43");
Console.WriteLine("Введите страницу:");
int k = int.Parse(Console.ReadLine());
if (k == 38)
{
    B:
    Console.WriteLine("-------------------------------\nДоступные номера: 1, 4, 6, 7, 9, 10, 12");
    Console.WriteLine("Введите номер");
    int kk = int.Parse(Console.ReadLine());
    if (kk == 1)
    {
    Console.WriteLine("1. Найти сумму элементов последовательности.");
    int summa = 0;
    while (true)
    {
        Console.WriteLine("Введите очередное число последовательности a:");
        int a = int.Parse(Console.ReadLine());
            summa += a;
        Console.WriteLine("Продолжить ввод? Y/N");
        if (Console.ReadLine() == "N")
        {
            break;
        }
    }
        Console.WriteLine($"Сумма элементов последовательности = {summa}");
        goto A;
    }
    else if (kk == 4)
    {
        Console.WriteLine("4. Определить сколько раз в последовательности встречается заданное число.");
        int b = 0;
        Console.WriteLine("Введите число для нахождения:");
        var y = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            Console.WriteLine("Введите очередное число последовательности a:");
            int a = int.Parse(Console.ReadLine());
            if (a == y) { b++; }
            Console.WriteLine("Продолжить ввод? Y/N");
            if (Console.ReadLine() == "N")
            {
                break;
            }
        }
        Console.WriteLine($"Заданное число встречается {b} раз(а)");
        goto A;
    }
    else if(kk == 6)
    {
    Console.WriteLine("6. Найти произведение элементов последовательности.");
    int summa = 1;
    while (true)
    {
        Console.WriteLine("Введите очередное число последовательности a:");
        int a = int.Parse(Console.ReadLine());
            summa *= a;
        Console.WriteLine("Продолжить ввод? Y/N");
        if (Console.ReadLine() == "N")
        {
            break;
        }
    }
        Console.WriteLine($"Произведение элементов последовательности = {summa}");
        goto A;
    }
    else if (kk == 7)
    {
    Console.WriteLine("7. Найти сумму модулей элементов последовательности.");
    int summa = 0;
    while (true)
    {
        Console.WriteLine("Введите очередное число последовательности a:");
        int a = int.Parse(Console.ReadLine());
            summa += Math.Abs(a);
        Console.WriteLine("Продолжить ввод? Y/N");
        if (Console.ReadLine() == "N")
        {
            break;
        }
    }
        Console.WriteLine($"Сумма модулей элементов последовательности = {summa}");
        goto A;
    }
    else if (kk == 9)
    {
    Console.WriteLine("9. Вычислить сумму квадратов элементов последовательности.");
    double summa = 0;
    while (true)
    {
        Console.WriteLine("Введите очередное число последовательности a:");
        int a = int.Parse(Console.ReadLine());
            summa += Math.Pow(a, 2);
        Console.WriteLine("Продолжить ввод? Y/N");
        if (Console.ReadLine() == "N")
        {
            break;
        }
    }
        Console.WriteLine($"Сумма квадратов элементов последовательности = {summa}");
        goto A;
    }
    else if (kk == 10)
    {
    Console.WriteLine("10. Определить среднеее арифметическое последовательности.");
    int summa = 0; int zzz = 0;
    while (true)
    {
        Console.WriteLine("Введите очередное число последовательности a:");
        int a = int.Parse(Console.ReadLine());
            if (a == 0) 
            { 
                summa += a;
            } 
            else 
            {
                summa += a;
                zzz += 1;
            }
        Console.WriteLine("Продолжить ввод? Y/N");
        if (Console.ReadLine() == "N")
        {
            break;
        }
    }
        Console.WriteLine($"Сумма элементов последовательности = {summa / zzz}");
        goto A;
    }
    else if (kk == 12)
    {
    Console.WriteLine("12. Найти произведение модулей элементов последовательности.");
    int summa = 0;
    while (true)
    {
        Console.WriteLine("Введите очередное число последовательности a:");
        int a = int.Parse(Console.ReadLine());
            summa *= Math.Abs(a);
        Console.WriteLine("Продолжить ввод? Y/N");
        if (Console.ReadLine() == "N")
        {
            break;
        }
    }
        Console.WriteLine($"Сумма модулей элементов последовательности = {summa}");
        goto A;
    }
    else
    {
        Console.WriteLine("-------------------------------\n!!!Введен неверный номер задания!!!");
        goto B;
    }
}
else if (k == 41)
{
    Console.WriteLine("1. Найти сумму первой и последней цифр натурального числа n.");
    Console.WriteLine("Введите натуральное число");
    int sh = int.Parse(Console.ReadLine());
    int last = sh % 10;
    int first = sh;
    while (first >= 10)
    {
        first /= 10;
    }
    Console.WriteLine($"Сумма первой и последней цифры: {first} + {last} = {first + last}");
    goto A;
}
else if (k == 33)
{
    Console.WriteLine("3. Дано натуральное число N. Вычислить произведение первых N сомножителей выражения (2 * N) / (2 * N + 1).");
    Console.WriteLine("Введите натуральное число N:");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число первых сомножитилей X:");
    int X = int.Parse(Console.ReadLine());
    double summa = 1.0; double C = 0; double V = 0;
    for (int x = 0;  x+1 <= X; x++)
    {
        C = 2.0 * N; V = C + 1.0;
        summa *= C / V;
        N++;
    }
    Console.WriteLine($"Произведение первых N сомножителей = {Math.Round(summa, 5)}");
    goto A;
}
else if (k == 36)
{
    Console.WriteLine("1(б). Дан числовой ряд и некоторые число e.\nНайти сумму тех членов ряда, модуль которых больше или равен заданному числу e.");
    Console.WriteLine("Введите некоторое число e:");
    double e = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите натуральное число n:");
    double n = Convert.ToDouble(Console.ReadLine());
    double summa = 1.0; double an = 0; double an2 = 0;
    an = 1 / Math.Pow(2, n) + 1 / Math.Pow(3, n);
    an2 = Math.Abs(an);
    if (an2 >= e)
    {
    Console.WriteLine($"Сумма членов ряда > e; Сумма членов ряда = {an2}");
    }
    else
    Console.WriteLine($"Сумма членов ряда < e");
    goto A;
}
else if (k == 43)
{
    Console.WriteLine("1. Дано натуральное число n. Проверить, все ли цифры в этом числе различные.");
    Console.WriteLine("Введите натуральное число n");
    var val = Convert.ToInt32(Console.ReadLine());
    var digits = new HashSet<int>();
    var distinct = true;
    for (val = Math.Abs(val); val != 0; val /= 10)
        if (!digits.Add(val % 10))
        {
            distinct = false;
            break;
        }
    Console.WriteLine(distinct ? "Цифры различны" : "Цифры повторяются");
    goto A;
}
else
{
    Console.WriteLine("-------------------------------\n!!!Введена неверная страница!!!");
    goto A;
}