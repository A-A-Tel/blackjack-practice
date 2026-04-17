using System;
using System.Reactive;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using ReactiveUI;

namespace Blackjack.ViewModels.Card;

public class CardViewModel : ViewModelBase
{
    private static readonly Bitmap BackImage =
        new(AssetLoader.Open(new Uri("avares://Blackjack/Assets/Cards/back.png")));

    private readonly Models.Card.Card _card;

    public CardViewModel(Models.Card.Card card)
    {
        _card = card;

        Image = new Bitmap(AssetLoader.Open(
            new Uri($"avares://Blackjack/Assets/Cards/{Suit}{Rank}.png")));

        Flip = ReactiveCommand.Create(() =>
        {
            _card.Flip();
            this.RaisePropertyChanged(nameof(IsFlipped));
            this.RaisePropertyChanged(nameof(Image));
        });
    }

    private string Rank => _card.Rank.ToString();
    private string Suit => _card.Suit.ToString();

    private bool IsFlipped => _card.Flipped;

    public Bitmap Image => IsFlipped ? BackImage : field;

    public ReactiveCommand<Unit, Unit> Flip { get; }
}