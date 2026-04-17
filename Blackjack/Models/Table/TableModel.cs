using System.Collections.Generic;
using Blackjack.Models.Player;
using static System.Enum;

namespace Blackjack.Models.Table;

public class TableModel
{
    public int Rounds { get; private set; }

    public IReadOnlyList<PlayerModel> Players => _players;
    private readonly List<PlayerModel> _players = [];

    public DealerModel Dealer { get; private init; }
    
    public GameState State { get; private set; } = GameState.Deal;

    public TableModel(int playerCount, int rounds)
    {
        Rounds = rounds;
        Dealer = new DealerModel();
        
        for (int i = 0; i < playerCount; i++)
            _players.Add(new PlayerModel());
    }
    
    public void Advance()
    {
        State = (GameState)(( (int)State + 1) % GetValues(typeof(GameState)).Length);
    }

    public void Deal()
    {
        throw new System.NotImplementedException();
    }

    public void Bet()
    {
        throw new System.NotImplementedException();
    }

    public void Play()
    {
        throw new System.NotImplementedException();
    }

    public void Payout()
    {
        throw new System.NotImplementedException();
    }
}