using System.Windows.Input;
using Blackjack.Models.Table;
using Blackjack.Services;
using Blackjack.ViewModels.Table;
using ReactiveUI;

namespace Blackjack.ViewModels.Menu;

public class TitleViewModel : PageViewModelBase
{
    public TitleViewModel(NavigationService navigationService) : base(navigationService)
    {
        GoToTable = ReactiveCommand.Create(() =>
            NavigationService.NavigateTo(new TableViewModel(navigationService, new TableModel(2, 1))));
    }

    public ICommand GoToTable { get; }
}