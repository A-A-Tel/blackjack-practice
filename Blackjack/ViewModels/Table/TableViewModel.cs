using System.Collections.ObjectModel;
using Blackjack.Models.Player;
using Blackjack.Models.Table;
using Blackjack.Services;
using Blackjack.ViewModels.Player;
using ReactiveUI;

namespace Blackjack.ViewModels.Table;

public class TableViewModel : PageViewModelBase
{
    private readonly TableModel _table;

    public TableViewModel(NavigationService navigationService, TableModel table) : base(navigationService)
    {
        _table = table;
        FillPlayers();
    }

    public ObservableCollection<PlayerViewModel> Players { get; } = [];
    public DealerViewModel Dealer => new(_table.Dealer);
    public GameState State => _table.State;

    private void FillPlayers()
    {
        foreach (PlayerModel player in _table.Players)
            Players.Add(new PlayerViewModel(player));
        
        this.RaisePropertyChanged(nameof(Players));
    }
}