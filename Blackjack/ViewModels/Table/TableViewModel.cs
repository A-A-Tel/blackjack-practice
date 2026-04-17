using Blackjack.Models.Card;
using Blackjack.Services;
using Blackjack.ViewModels.Card;

namespace Blackjack.ViewModels.Table;

public class TableViewModel : PageViewModelBase
{
    private readonly ShoeModel _shoeModel = new(2);

    public TableViewModel(NavigationService navigationService) : base(navigationService)
    {
    }

    public HandViewModel Hand { get; } = new(new HandModel());
}