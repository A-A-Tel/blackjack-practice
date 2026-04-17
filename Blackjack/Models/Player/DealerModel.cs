using System;
using System.Collections.Generic;
using Blackjack.Models.Card;

namespace Blackjack.Models.Player;

public class DealerModel
{
    public DealerModel()
    {
    }

    public HandModel Hand { get; } = new();
    public ShoeModel Shoe { get; } = new(4);
    
    public void Deal(IEnumerable<PlayerModel> players)
    {
        throw new NotImplementedException();
    }

    public void Bet()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
    }

    public void Payout()
    {
        throw new NotImplementedException();
    }
}