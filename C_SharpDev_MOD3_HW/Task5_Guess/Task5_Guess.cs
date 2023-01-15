Console.Write("Введите максимальное число диапазона: ");
int limit_upper = int.Parse(Console.ReadLine());

var random = new Random();
int number_target = random.Next(0, limit_upper + 1);

//Console.WriteLine($"({number_target})");

while (true)
{
    Console.Write("Угадайте число (или нажмите Enter для выхода): ");
    var user_response = Console.ReadLine();

    if (user_response == "") break;
    
    int number_guess = int.Parse(user_response);

    if (number_target == number_guess)
    {
        Console.WriteLine("Угадали!");
        break;
    }
    else if (number_target > number_guess) Console.WriteLine("Загаданное число больше.");
    else if (number_target < number_guess) Console.WriteLine("Загаданное число меньше.");
}

