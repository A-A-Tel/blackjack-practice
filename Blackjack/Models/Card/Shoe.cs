using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack.Models.Card;

public class Shoe
{
    private Queue<Card> _cards;

    public Shoe(int deckSize)
    {
        Queue<Card> cards = new();

        for (int i = 0; i < deckSize; i++)
            foreach (CardSuit suit in Enum.GetValuesAsUnderlyingType<CardSuit>())
            foreach (CardRank rank in Enum.GetValuesAsUnderlyingType<CardRank>())
                cards.Enqueue(new Card(suit, rank, true));

        _cards = cards;
    }

    public void Shuffle()
    {
        _cards = new Queue<Card>(_cards.Shuffle());
    }

    public Card Draw()
    {
        return _cards.Dequeue();
    }

    public void Append(Card card)
    {
        _cards.Enqueue(card);
    }
}