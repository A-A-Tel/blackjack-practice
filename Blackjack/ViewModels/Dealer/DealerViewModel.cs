using Blackjack.Models.Player;
using Blackjack.ViewModels.Card;

namespace Blackjack.ViewModels.Player;

public class DealerViewModel : ViewModelBase
{
    private readonly DealerModel _dealer;

    public DealerViewModel(DealerModel dealer)
    {
        _dealer = dealer;
    }

    public HandViewModel Hand => new(_dealer.Hand);
    public ShoeViewModel Shoe => new(_dealer.Shoe);
}