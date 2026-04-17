using System.Reactive;
using Blackjack.Models.Card;
using Blackjack.Models.Player;
using ReactiveUI;

namespace Blackjack.ViewModels.Player;

public class DealerViewModel
{
    private DealerModel _dealer;

    public DealerViewModel(DealerModel dealer)
    {
        _dealer = dealer;
    }
    
    public HandModel Hand => _dealer.Hand;
    public ShoeModel Shoe => _dealer.Shoe;
}