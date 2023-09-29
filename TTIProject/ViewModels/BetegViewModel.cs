using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TTIProject.Models;

namespace TTIProject.ViewModels
{
    public partial class BetegViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _resultIsVisible;

        [ObservableProperty]
        private Beteg _beteg;

        public BetegViewModel()
        {
            Beteg = new Beteg();
            ResultIsVisible = false;
        }

        public double TTI => Beteg.TTI;
        public string BetegAdatok => Beteg.BetegAdatok;

        public string Nev
        {
            get => Beteg.Nev;
            set
            {
                Beteg.Nev = value;
                ResultIsVisible = false;
            }
        }

        public double Magassag
        {
            get => Beteg.Magassag;
            set
            {
                Beteg.Magassag = value;
                ResultIsVisible = false;
            }
        }

        public double Suly
        {
            get => Beteg.Suly;
            set
            {
                Beteg.Suly = value;
                ResultIsVisible = false;
            }
        }

        [RelayCommand]
        public void DoTTICompute()
        {
            OnPropertyChanged(nameof(TTI));
            OnPropertyChanged(nameof(BetegAdatok));
            ResultIsVisible = true;
        }
    }
}
