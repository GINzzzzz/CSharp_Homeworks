bool simple = true;
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;

while (i < (n - 1))
{
    i += 1;
    if (n % i == 0)
    {
        simple = false;
        break;
    }
}

if (simple == true) Console.WriteLine("Число является простым");
else Console.WriteLine("Число не является простым");