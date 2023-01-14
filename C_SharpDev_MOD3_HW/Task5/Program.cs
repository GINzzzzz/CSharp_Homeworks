Console.Write("Введите максимальное число: ");
int max_val = int.Parse(Console.ReadLine());
Random rand = new Random();
int target_n = rand.Next(0, max_val + 1);
Console.WriteLine($"({target_n})");

while (true)
{
    Console.Write("Угадайте число (нажмите Enter, чтобы выйти): ");
    var guess = Console.ReadLine();

    if (guess != "")
    {
        int user_n = int.Parse(guess);

        if (user_n == target_n)
        {
            Console.WriteLine("Угадали!");
            break;
        }
        else if (user_n < target_n) Console.WriteLine("Загаданное число больше.");
        else if (user_n > target_n) Console.WriteLine("Загаданное число меньше.");
    }
    else break;
}