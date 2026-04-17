using Blackjack.Models.Card;

namespace Blackjack.Models.Player;

public class PlayerModel
{
    private Chipset _chipset = new();
    public HandModel HandModel { get; } = new();
    public string Name { get; }

    public Action GetAction()
    {
        int value = HandModel.GetValue();
        return HandModel.GetValue() switch
        {
            < 6 => Action.Double,
            >= 17 => Action.Stand,
            _ => Action.Hit
        };
    }
}