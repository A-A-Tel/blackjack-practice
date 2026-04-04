using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack.Models.Card;

public class Shoe
{
    private Queue<CardModel> _cards;

    public Shoe(int deckSize)
    {
        Queue<CardModel> cards = new();

        for (int i = 0; i < deckSize; i++)
            foreach (CardSuit suit in Enum.GetValuesAsUnderlyingType<CardSuit>())
            foreach (CardRank rank in Enum.GetValuesAsUnderlyingType<CardRank>())
                cards.Enqueue(new CardModel(suit, rank, true));

        _cards = cards;
    }

    public void Shuffle()
    {
        _cards = new Queue<CardModel>(_cards.Shuffle());
    }

    public CardModel Draw()
    {
        return _cards.Dequeue();
    }

    public void Append(CardModel cardModel)
    {
        _cards.Enqueue(cardModel);
    }
}