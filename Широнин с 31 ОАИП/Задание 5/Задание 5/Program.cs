Console.WriteLine("Все возможные сочетания:");
for (int g = 0; g <= 64; g += 4)
{
    Console.WriteLine($"Кролики: {g / 4}  Гуси: {(64 - g) / 2}");
}