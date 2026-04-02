using System.Collections.ObjectModel;
using System.Windows.Input;
using Blackjack.Models.Card;
using Blackjack.Services;
using Blackjack.ViewModels.Card;
using ReactiveUI;

namespace Blackjack.ViewModels.Table;

public class TableViewModel : PageViewModelBase
{
    private readonly Shoe _shoe = new(2);

    public TableViewModel(NavigationService navigationService) : base(navigationService)
    {
        DrawCard = ReactiveCommand.Create(() => { Cards.Add(new CardViewModel(_shoe.Draw())); });
    }

    public ObservableCollection<CardViewModel> Cards { get; } = [];

    public ICommand DrawCard { get; }
}