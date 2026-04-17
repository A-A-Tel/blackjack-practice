using System.Collections.ObjectModel;
using Blackjack.Models.Card;
using ReactiveUI;

namespace Blackjack.ViewModels.Card;

public class HandViewModel : ViewModelBase
{
    private readonly HandModel _handModel;

    public HandViewModel(HandModel handModel)
    {
        _handModel = handModel;
        FillCards();
    }

    public ObservableCollection<CardViewModel> Cards { get; } = [];

    public int Value => _handModel.GetValue();

    public void AddCard(CardModel cardModel)
    {
        _handModel.AddCard(cardModel);
        Cards.Add(new CardViewModel(cardModel));
        this.RaisePropertyChanged(nameof(Cards));
    }

    private void FillCards()
    {
        foreach (CardModel card in _handModel.Cards) Cards.Add(new CardViewModel(card));

        this.RaisePropertyChanged(nameof(Cards));
        this.RaisePropertyChanged(nameof(Value));
    }
}