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
    }

    private void OnPointerEntered(object? sender, PointerEventArgs e)
    {
        HoverValueText.IsVisible = true;
    }

    private void OnPointerExited(object? sender, PointerEventArgs e)
    {
        HoverValueText.IsVisible = false;
    }

    private void OnPointerMoved(object? sender, PointerEventArgs e)
    {
        var pos = e.GetPosition(this);

        Canvas.SetLeft(HoverValueText, pos.X + 15);
        Canvas.SetTop(HoverValueText, pos.Y + 15);
    }
}