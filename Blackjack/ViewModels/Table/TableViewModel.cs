using System.Collections.Generic;
using Blackjack.Models.Player;
using Blackjack.Models.Table;
using Blackjack.Services;
using Blackjack.ViewModels.Player;

namespace Blackjack.ViewModels.Table;

public class TableViewModel : PageViewModelBase
{
    private readonly TableModel _table;

    public TableViewModel(NavigationService navigationService, TableModel table) : base(navigationService)
    {
        _table = table;
    }

    public IReadOnlyList<PlayerModel> Players => _table.Players;
    public DealerViewModel Dealer => new(_table.Dealer);
    public GameState State => _table.State;
}