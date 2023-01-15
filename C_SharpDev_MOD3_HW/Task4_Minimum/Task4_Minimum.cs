Console.Write("Введите длину последовательности: ");
int cnt_numbers = int.Parse(Console.ReadLine());
int minimum = int.MaxValue;
Console.WriteLine("\nВводите числа последовательности (через Enter):");

for (int i = 0; i < cnt_numbers; i++)
{
    int number = int.Parse(Console.ReadLine());
    
    if (number < minimum)
    {
        minimum = number;
    }
}

Console.WriteLine($"\nНаименьший элемент в последовательности: {minimum}");