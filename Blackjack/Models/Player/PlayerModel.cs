using Blackjack.Models.Card;
using NameGenerator.Generators;

namespace Blackjack.Models.Player;

public class PlayerModel
{
    private static readonly RealNameGenerator NameGenerator = new();
    public HandModel Hand { get; } = new();

    public ChipsetModel Chipset { get; } = new();

    public string Name { get; } = NameGenerator.Generate();

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