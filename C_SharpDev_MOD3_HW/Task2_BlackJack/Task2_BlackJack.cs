Console.Write("Введите количество карт в руке: ");
int cnt_hand = int.Parse(Console.ReadLine());
int summa_hand = 0;

for (int i = 0; i < cnt_hand; i++)
{
    Console.Write($"Введите номинал карты {i+1}: ");
    var card = Console.ReadLine();

    switch(card.ToUpper())
    {
        case ("J" or "Q" or "K" or "A"):
            summa_hand += 10;
            break;
        case ("2" or "3" or "4" or "5" or "6" or "7" or "8" or "9" or "10"):
            summa_hand += int.Parse(card);
            break;
        default:
            break;
    }
}

Console.WriteLine($"Сумма карт в руке: {summa_hand}");