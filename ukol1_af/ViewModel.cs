using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ukol1_af
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        double _vysledekMesicne = 0;
        double _vysledekRocne = 0;
        public int VyseUveru { get; set; }
        public float UrokovaSazba { get; set; }
        public int DobaSplaceni { get; set; }
        public double VysledekMesicne
        {
            get => _vysledekMesicne;
            set { _vysledekMesicne = value; OnPropertyChanged(nameof(VysledekMesicne)); }
        }
        public double VysledekCelkem
        {
            get => _vysledekRocne;
            set { _vysledekRocne = value; OnPropertyChanged(nameof(VysledekCelkem)); }
        }
        public Command Vypocet { get; set; }

        public ViewModel()
        {
            Vypocet = new Command(Spocitej);
        }
        private void Spocitej()
        {
            double v, i;
            i = (UrokovaSazba / 100) / 12;
            v = 1 / (1 + i);
            VysledekMesicne = i * VyseUveru / (1 - Math.Pow(v, DobaSplaceni * 12));
            VysledekCelkem = VysledekMesicne * DobaSplaceni * 12;
        }
    }
}
