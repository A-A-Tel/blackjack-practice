using Blackjack.Models.Card;
using Blackjack.Models.Player;

namespace Blackjack.ViewModels.Player;

public class PlayerViewModel : ViewModelBase
{
    private readonly PlayerModel _player;
    
    public PlayerViewModel(PlayerModel player)
    {
        _player = player;
    }
    
    public ChipsetModel Chipset =>  _player.Chipset;
    public HandModel Hand => _player.Hand;
    public string Name => _player.Name;
    
    
}