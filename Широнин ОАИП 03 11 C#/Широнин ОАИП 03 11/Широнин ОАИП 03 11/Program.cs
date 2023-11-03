Console.WriteLine("Доступны 10 и 13 стр");
Console.WriteLine("Введите страницу:");
int page = Convert.ToInt32(Console.ReadLine());
switch (page)
{
    case 10:
        // с.10 № 18
        // N = 567
        int N = int.Parse(Console.ReadLine());
        int c3 = N % 10;
        int c1 = N / 100;
        int c2 = N / 10 % 10; // N % 100 / 10
        Console.WriteLine($"{c1} \n {c2} \n {c3} \n {c3 - c2 == c2 - c1 && c2 - c1 !=0}");
    break;
    case 13:
        Console.WriteLine("Доступны задания 1, 2, 3, 4:");
        Console.WriteLine("Введите номер задания:");
        int exec = Convert.ToInt32(Console.ReadLine());
        switch (exec)
        { 
        case 1:
            // c.13 №1
            //для каждой линии нужно определить уравнение
            //для закрашенной области определить систему неравенств
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            // y >= 0
            // y <= x + 4
            // y <= -x + 4           1 < -1 + 4
            Console.WriteLine(y >= 0 && y <= x + 4 && y <= -x + 4);
        break;
        case 2:
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine((x1 * x1)+(y1 * y1)>=9 && (x1 * x1) + (y1 * y1) <= 25 && x1 >= 0);
        break;
        case 3:
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine((x2 >= -2) && (x2 <= 2) && (y2 <= 4) && (y2 >= -3) | (x2 >= -4) && (x2 <= 5) && (y2 <= 0) && (y2 >= -3));
        break;
        case 4:
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            Console.WriteLine((y3 >=5 - x3) && (y3 <= 11 - x3) && (y3 <= x3 + 3) && (y3 >= x3 - 3) );
        break;
        }
    break;
}