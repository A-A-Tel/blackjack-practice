using ReactiveUI;

namespace Blackjack.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ViewModelBase? CurrentPage
    {
        get;
        set => this.RaiseAndSetIfChanged(ref field, value);
    } = null;
}