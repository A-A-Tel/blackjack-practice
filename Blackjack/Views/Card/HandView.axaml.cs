using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Blackjack.Views.Card;

public partial class HandView : UserControl
{
    public HandView()
    {
        InitializeComponent();

        PointerMoved += OnPointerMoved;
        PointerEntered += OnPointerEntered;
        PointerExited += OnPointerExited;
        HoverValueBlock.IsVisible = false;
    }

    private void OnPointerEntered(object? sender, PointerEventArgs e)
    {
        HoverValueBlock.IsVisible = true;
    }

    private void OnPointerExited(object? sender, PointerEventArgs e)
    {
        HoverValueBlock.IsVisible = false;
    }

    private void OnPointerMoved(object? sender, PointerEventArgs e)
    {
        Point pos = e.GetPosition(this);

        Canvas.SetLeft(HoverValueBlock, pos.X + 15);
        Canvas.SetTop(HoverValueBlock, pos.Y + 15);
    }
}