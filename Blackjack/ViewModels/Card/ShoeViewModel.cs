using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Blackjack.Models.Card;

namespace Blackjack.ViewModels.Card;

public class ShoeViewModel : ViewModelBase
{
    private readonly ShoeModel _shoe;

    public ShoeViewModel(ShoeModel shoe)
    {
        _shoe = shoe;
    }

    public Bitmap Image { get; } = new(AssetLoader.Open(new Uri("avares://Blackjack/Assets/Cards/stack.png")));
}