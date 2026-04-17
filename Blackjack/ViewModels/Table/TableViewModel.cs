using System.Collections.Generic;
using System.Collections.ObjectModel;
using Blackjack.Models.Card;
using Blackjack.Models.Player;
using Blackjack.Models.Table;
using Blackjack.Services;
using Blackjack.ViewModels.Card;

namespace Blackjack.ViewModels.Table;

public class TableViewModel : PageViewModelBase
{
    private readonly TableModel _table;

    public TableViewModel(NavigationService navigationService, TableModel table) : base(navigationService)
    {
        _table = table;
    }
    
    public IReadOnlyList<PlayerModel> Players => _table.Players;
    public DealerModel Dealer => _table.Dealer;
    public GameState State => _table.State;

}