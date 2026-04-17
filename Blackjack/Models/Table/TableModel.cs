using System;
using System.Collections.Generic;
using Blackjack.Models.Player;

namespace Blackjack.Models.Table;

public class TableModel
{
    private readonly List<PlayerModel> _players = [];

    public TableModel(int playerCount, int rounds)
    {
        Rounds = rounds;
        Dealer = new DealerModel();

        for (int i = 0; i < playerCount; i++)
            _players.Add(new PlayerModel());
    }

    public int Rounds { get; private set; }

    public IReadOnlyList<PlayerModel> Players => _players;

    public DealerModel Dealer { get; private init; }

    public GameState State { get; private set; } = GameState.Deal;

    public void Advance()
    {
        State = (GameState)(((int)State + 1) % 4);
    }

    public void Deal()
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