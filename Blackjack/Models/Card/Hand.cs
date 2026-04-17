using System.Collections.Generic;

namespace Blackjack.Models.Card;

public class Hand
{
    private readonly List<Card> _cards = [];

    public void Hit(Card card)
    {
        _cards.Add(card);
    }

    public int GetValue()
    {
        int aceCount = 0;
        int value = 0;

        foreach (Card card in _cards)
        {
            if (card.Rank == Rank.Ace) aceCount++;
            value += card.Value;
        }

        while (value > 21 && aceCount > 0)
        {
            value -= 10;
            aceCount--;
        }

        return value;
    }
}