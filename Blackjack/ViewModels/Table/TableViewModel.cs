using System.Collections.ObjectModel;
using System.Windows.Input;
using Blackjack.Models.Card;
using Blackjack.Services;
using Blackjack.ViewModels.Card;
using ReactiveUI;

namespace Blackjack.ViewModels.Table;

public class TableViewModel : PageViewModelBase
{
    public HandViewModel Hand { get; } = new(new Hand());
    
    private readonly Shoe _shoe = new(2);

    public TableViewModel(NavigationService navigationService) : base(navigationService)
    {
    }

}