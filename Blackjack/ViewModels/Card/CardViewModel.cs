using System;
using System.Reactive;
using System.Windows.Input;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Blackjack.Models.Card;
using ReactiveUI;

namespace Blackjack.ViewModels.Card;

public class CardViewModel : ViewModelBase
{
    private static readonly Bitmap BackImage =
        new(AssetLoader.Open(new Uri("avares://Blackjack/Assets/Cards/back.png")));

    public CardViewModel(CardModel cardModel)
    {
        _cardModel = cardModel;

        Image = new Bitmap(AssetLoader.Open(
            new Uri($"avares://Blackjack/Assets/Cards/{Suit}{Rank}.png")));

        Flip = ReactiveCommand.Create(() =>
        {
            _cardModel.Flip();
            this.RaisePropertyChanged(nameof(IsFlipped));
            this.RaisePropertyChanged(nameof(Image));
        });
    }

    private readonly CardModel _cardModel;

    private string Rank => _cardModel.Rank.ToString();
    private string Suit => _cardModel.Suit.ToString();

    private bool IsFlipped => _cardModel.Flipped;

    public Bitmap Image => IsFlipped ? BackImage : field;
    
    public ICommand Flip { get; }
}