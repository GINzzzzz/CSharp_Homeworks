Console.Write("Введите количество карт в руке: ");
int cnt_hand = int.Parse(Console.ReadLine());
int summa_hand = 0;

for (int i = 0; i < cnt_hand; i++)
{
    Console.Write($"Введите номинал карты {i+1}: ");
    var card = Console.ReadLine();

    switch(card)
    {
        case "J":
            summa_hand += 10;
            break;
        case "Q":
            summa_hand += 10;
            break;
        case "K":
            summa_hand += 10;
            break;
        case "A":
            summa_hand += 10;
            break;
        default:
            summa_hand += int.Parse(card);
            break;
    }
}

Console.WriteLine($"Сумма карт в руке: {summa_hand}");