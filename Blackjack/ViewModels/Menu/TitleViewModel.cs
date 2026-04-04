using System.Windows.Input;
using Blackjack.Services;
using Blackjack.ViewModels.Table;
using ReactiveUI;

namespace Blackjack.ViewModels.Menu;

public class TitleViewModel : PageViewModelBase
{
    public TitleViewModel(NavigationService navigationService) : base(navigationService)
    {
        GoToTable = ReactiveCommand.Create(() => NavigationService.NavigateTo(new TableViewModel(navigationService)));
    }

    public ICommand GoToTable { get; }
}