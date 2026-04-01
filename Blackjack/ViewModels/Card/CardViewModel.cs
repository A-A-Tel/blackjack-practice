using ReactiveUI;

namespace Blackjack.ViewModels.Card;

public class CardViewModel : ViewModelBase
{
    private readonly Models.Card.Card _card;

    public CardViewModel(Models.Card.Card card)
    {
        _card = card;
    }

    public string Rank => _card.Rank.ToString();
    public string Suit => _card.Suit.ToString();

    public bool IsFlipped => _card.Flipped;

    public string Display => $"{Rank} of {Suit}";

    public string ImagePath =>
        IsFlipped
            ? $"/Assets/Cards/{Rank}_of_{Suit}.png"
            : "/Assets/Cards/back.png";

    public void Flip()
    {
        _card.Flip();
        this.RaisePropertyChanged(nameof(IsFlipped));
        this.RaisePropertyChanged(nameof(ImagePath));
    }
}