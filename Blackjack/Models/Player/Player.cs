using Blackjack.Models.Card;

namespace Blackjack.Models.Player;

public class Player
{
    private Chipset _chipset = new();
    public CardHand Hand { get; } = new();
    public string Name { get; }

    public Action GetAction()
    {
        int value = Hand.GetValue();
        return Hand.GetValue() switch
        {
            < 6 => Action.Double,
            >= 17 => Action.Stand,
            _ => Action.Hit
        };
    }
}