A:
Console.WriteLine("-------------------------------\nДоступные страницы: 21, 34, 39");
Console.WriteLine("Введите страницу:");
int k = int.Parse(Console.ReadLine());
if (k == 21)
{
B:
    Console.WriteLine("-------------------------------\nДоступные номера: 20, 25");
    Console.WriteLine("Введите номер");
    int kk = int.Parse(Console.ReadLine());
    if (kk == 20)
    {
        Console.WriteLine("20. Определить пройдёт ли график функции y=ax^2 + bx + c через заданную точку с координатами (m,n)");
        Console.WriteLine("Введите координату m:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату a:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату b:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите координату c:");
        int c = int.Parse(Console.ReadLine());
        int y = (a * m * m) + (b * m) + c;
        if (n == y)
        {
            Console.WriteLine($"График пройдёт через точку");
        }
        else
        {
            Console.WriteLine($"График НЕ пройдёт через точку");
        }
        goto A;
    }
    else if (kk == 25)
    {
        Console.WriteLine("25. Сравнить объёмы двух прямоугольных параллепипедов, заданных своими измерениями.");
        Console.WriteLine("Введите высоту a для умножения");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту b для умножения");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту c для умножения");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту a1 для умножения");
        double a1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту b1 для умножения");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту c1 для умножения");
        double c1 = Convert.ToDouble(Console.ReadLine());
        double v1 = a * b * c;
        double v2 = a1 * b1 * c1;
        if (v1 == v2)
        {
            Console.WriteLine($"Объёмы равны. Объём первого параллелипипеда {v1}, а второго - {v2}");
        }
        else
            Console.WriteLine($"Объёмы не равны. Объём первого параллелипипеда {v1}, а второго - {v2}");
        goto A;
    }
    else
    goto B;
}
if (k == 34)
{
B:
    Console.WriteLine("-------------------------------\nДоступные номера: 4, 11");
    Console.WriteLine("Введите номер");
    int kk = int.Parse(Console.ReadLine());
    if (kk == 4)
    {
        Console.WriteLine("4. Дано натуральное число N. Вычислить выражение. Cos(1)/Sin(1) * Cos(1) + Cos (2)/Sin(1) * Sin(2)...");
        Console.WriteLine("//Для решения этой задачи был использван способ конвертирования косинуса \nи синуса из радиан в градусы (Math.Cos(x * Math.PI / 180)");
        Console.WriteLine("Введите число N:");
        double N = Convert.ToDouble(Console.ReadLine());
        double C = 0.0; double V = 0.0; double summa = 1.0; double summa2 = 1.0;
        for (double x = 1.0; x <= N; x++)
        {
            C = C + Math.Cos(x * Math.PI / 180); V = V + Math.Sin(x * Math.PI / 180);
            summa = summa * (C / V);
        }
        for (double z = 1.0; z <= N; z++)
        {
            C = C + Math.Cos(z); V = V + Math.Sin(z);
            summa2 = summa2 * (C / V);
        }
        Console.WriteLine($"Результат выражения в градусах = {Math.Round(summa, 5)}\nРезультат выражения в радианах = {Math.Round(summa2, 5)}");
        goto A;
    }
    else if (kk == 11)
    {
        Console.WriteLine("11. Вычислить выражение. (1 + sin 0.1) * (1 + sin 0.2) ... * (1 + sin 10)");
        double C = 0.0; double V = 0.0; double summa = 1.0;
        for (double x = 0.1; x - 0.1 <= 10; x+= 0.1)
        {
            C = (1 + Math.Sin(x));
            summa = summa * C;
        }
        Console.WriteLine($"Результат выражения = {Math.Round(summa, 15)}; {summa}");
        goto A;
    }
}
else if (k == 39)
{
    C:
    Console.WriteLine("22. Найти сумму тех членов последовательности, которые оканчиваются на заданную цифру");
    Console.WriteLine("Введите заданную цифру:");
    int m = int.Parse(Console.ReadLine());
    if (m >= 10)
    {
        Console.WriteLine("-------------------------------\nЦифру от 1 до 9!");
        goto C;
    }
    else
    {
        double summa = 0;
        while (true)
        {
            Console.WriteLine("Введите очередное число последовательности a:");
            var a = int.Parse(Console.ReadLine());
            int last = a % 10;
            if (last == m)
            {
                summa += a;
            }
            else
            {
                last = 0;
            }
            Console.WriteLine("Продолжить ввод? Y/N");
            if (Console.ReadLine() == "N")
            {
                break;
            }
        }
        Console.WriteLine($"Сумма членов последовательности:{summa}");
    }
        goto A;
}
else
{
    Console.WriteLine("-------------------------------\n!!!Введена неверная страница!!!");
    goto A;
}