Console.Write("Приветствую! Сколько у Вас карт в руке? ");
int hand = 0;
int cnt_cards = int.Parse(Console.ReadLine());

for(int i = 0; i < cnt_cards; i++)
{
    Console.Write($"Введите карту {i + 1}: ");
    var card = Console.ReadLine();

    switch(card.ToUpper())
    {
        case "J":
            hand += 10;
            break;
        case "Q":
            hand += 10;
            break;
        case "K":
            hand += 10;
            break;
        case "A":
            hand += 10;
            break;
        default:
            hand += int.Parse(card);
            break;
    }
    Console.WriteLine(hand);
}    