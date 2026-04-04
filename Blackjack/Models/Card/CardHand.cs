using System.Collections.Generic;

namespace Blackjack.Models.Card;

public class CardHand
{
    private readonly List<CardModel> _cards = [];

    public void Hit(CardModel cardModel)
    {
        _cards.Add(cardModel);
    }

    public int GetValue()
    {
        int aceCount = 0;
        int value = 0;

        foreach (CardModel card in _cards)
        {
            if (card.Rank == CardRank.Ace) aceCount++;
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