using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TTIProject.Models;

namespace TTIProject.ViewModels
{
    public partial class BetegViewModel : ObservableObject
    {
        [ObservableProperty]
        private Beteg _beteg;

        public double TTI => Beteg.TTI;
        public string BetegAdatok => Beteg.BetegAdatok;

        [RelayCommand]
        public void DoTTICompute()
        {
            OnPropertyChanged(nameof(TTI));
            OnPropertyChanged(nameof(BetegAdatok));
        }
    }
}
