Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
bool prime = true;
int divider = 2;

while (divider < number)
{
    //Console.WriteLine($"({divider}) " + $"{number % divider}");

    if (number % divider == 0)
    {
        prime = false;
        break;
    }

    divider += 1;
}

if (prime)
{
    Console.WriteLine("Число простое.");
}
else Console.WriteLine("Число не является простым.");