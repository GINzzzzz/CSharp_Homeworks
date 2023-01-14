Console.Write("Введите длину последовательности: ");
int cnt_n = int.Parse(Console.ReadLine());
int min_n = int.MaxValue;

for (int i = 0; i < cnt_n; i++)
{
    Console.Write($"\nВведите число {i + 1}: ");
    int n = int.Parse(Console.ReadLine());
    
    if (n < min_n) min_n = n;
}

Console.WriteLine($"\nМинимальное число последовательности: {min_n}");