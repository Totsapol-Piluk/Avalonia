using System.Windows.Input;
using ReactiveUI;

namespace Avalonia.MusicStore.ViewModels;

public partial class MainWindowViewModel : ViewModelBase {
    public ICommand BuyMusicCommand { get; }
    
    public MainWindowViewModel() {
        BuyMusicCommand = ReactiveCommand.Create(() => {
            // This is where you would put your logic to buy music.
        });
    }
}