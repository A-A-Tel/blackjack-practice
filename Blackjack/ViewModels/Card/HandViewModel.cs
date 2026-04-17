using System.Collections.ObjectModel;
using Blackjack.Models.Card;
using ReactiveUI;

namespace Blackjack.ViewModels.Card;

public class HandViewModel : ViewModelBase
{
    public ObservableCollection<CardViewModel> Cards { get; } = [];
    private readonly Hand _hand;

    public int Value => _hand.GetValue();

    public HandViewModel(Hand hand)
    {
        _hand = hand;
        FillCards();
    }

    public void AddCard(Models.Card.Card card)
    {
        _hand.AddCard(card);
        Cards.Add(new CardViewModel(card));
        this.RaisePropertyChanged(nameof(Cards));
    }

    private void FillCards()
    {
        foreach (var card in _hand.Cards)
        {
            Cards.Add(new CardViewModel(card));
        }

        this.RaisePropertyChanged(nameof(Cards));
        this.RaisePropertyChanged(nameof(Value));
    }
}