Console.Write("Введите максимальное число диапазона: ");
int limitUpper = int.Parse(Console.ReadLine());

var random = new Random();
int numberTarget = random.Next(0, limitUpper + 1);

//Console.WriteLine($"({number_target})");

while (true)
{
    Console.Write("Угадайте число (или нажмите Enter для выхода): ");
    var userResponse = Console.ReadLine();

    if (userResponse == "") break;
    
    int numberGuess = int.Parse(userResponse);

    if (numberTarget == numberGuess)
    {
        Console.WriteLine("Угадали!");
        break;
    }
    else if (numberTarget > numberGuess) Console.WriteLine("Загаданное число больше.");
    else if (numberTarget < numberGuess) Console.WriteLine("Загаданное число меньше.");
}

