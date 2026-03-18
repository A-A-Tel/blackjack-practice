using System.Collections.Generic;

namespace Blackjack.Models.Card;

public class Card
{
    private static readonly Dictionary<CardRank, int> BlackjackValues = new()
    {
        { CardRank.Two, 2 },
        { CardRank.Three, 3 },
        { CardRank.Four, 4 },
        { CardRank.Five, 5 },
        { CardRank.Six, 6 },
        { CardRank.Seven, 7 },
        { CardRank.Eight, 8 },
        { CardRank.Nine, 9 },
        { CardRank.Ten, 10 },
        { CardRank.Jack, 10 },
        { CardRank.Queen, 10 },
        { CardRank.King, 10 },
        { CardRank.Ace, 11 }
    };

    public Card(CardSuit suit, CardRank rank, bool flipped)
    {
        Rank = rank;
        Suit = suit;
        Flipped = flipped;
        Value = BlackjackValues[rank];
    }

    public CardRank Rank { get; init; }
    public CardSuit Suit { get; init; }
    public int Value { get; init; }
    public bool Flipped { get; private set; }

    public void Flip()
    {
        Flipped = !Flipped;
    }
}