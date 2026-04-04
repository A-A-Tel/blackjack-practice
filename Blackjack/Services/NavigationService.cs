using Blackjack.ViewModels;

namespace Blackjack.Services;

public class NavigationService
{
    private readonly MainWindowViewModel _mainWindow;

    public NavigationService(MainWindowViewModel mainWindow)
    {
        _mainWindow = mainWindow;
    }

    public void NavigateTo(ViewModelBase vm)
    {
        _mainWindow.CurrentPage = vm;
    }
}