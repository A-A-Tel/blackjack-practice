using Blackjack.Models.Card;

namespace Blackjack.Models.Player;

public class Player
{
    public CardHand Hand { get; } = new();
    public string Name { get; }
    private Chipset _chipset = new();
    
}