using Blackjack.Models.Card;
using Blackjack.Models.Player;
using Blackjack.ViewModels.Card;

namespace Blackjack.ViewModels.Player;

public class PlayerViewModel : ViewModelBase
{
    private readonly PlayerModel _player;
    
    public PlayerViewModel(PlayerModel player)
    {
        _player = player;
        Hand = new HandViewModel(_player.Hand);
    }
    
    public ChipsetModel Chipset =>  _player.Chipset;
    public HandViewModel Hand { get; }
    public string Name => _player.Name;
}