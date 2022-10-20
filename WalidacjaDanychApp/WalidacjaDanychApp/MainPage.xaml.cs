using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WalidacjaDanychApp
{
    public partial class MainPage : ContentPage
    {
        #region pola
        private string _imie;
        private string _poprawnoscImienia;
        private string _wiek;
        private string _poprawnoscWieku;
        private string _niepelnoletnosc;
        private string _przywitanie;
        private string _kolor;
        #endregion

        #region Prop
        public string Imie
        {
            get
            {
                return _imie;
            }
            set
            {
                _imie = value;
                OnPropertyChanged();
            }
        }
        public string Wiek
        {
            get
            {
                return _wiek;
            }
            set
            {
                _wiek = value;
                OnPropertyChanged();
            }
        }
        public string PoprawnoscImienia
        {
            get
            {
                return _poprawnoscImienia;
            }
            set
            {
                _poprawnoscImienia = value;
                OnPropertyChanged();
            }
        }
        public string PoprawnoscWieku
        {
            get
            {
                return _poprawnoscWieku;
            }
            set
            {
                _poprawnoscWieku = value;
                OnPropertyChanged();
            }
        }
        public string Niepelnoletnosc
        {
            get
            {
                return _niepelnoletnosc;
            }
            set
            {
                _niepelnoletnosc = value;
                OnPropertyChanged();
            }
        }
        public string Przywitanie
        {
            get
            {
                return _przywitanie;
            }
            set
            {
                _przywitanie = value;
                OnPropertyChanged();
            }
        }
        public string Kolor 
        { 
            get
            {
                return _kolor;
            }
            set
            {
                _kolor = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region obiekty walidacji
        Walidacja walidacja = new Walidacja();
        WalidacjaImienia walidacjaImienia = new WalidacjaImienia();
        WalidacjaWieku walidacjaWieku = new WalidacjaWieku();
        #endregion

        public MainPage()
        {
            
            InitializeComponent();
            
        }

        private void sprawdzButton_Clicked(object sender, EventArgs e)
        {
            PrzywitanieLabel.Text = "";
            NiepelnoletnoscLabel.Text = "";
            string wiadomosc = "";
            if (!walidacja.WykonajWalidacje(ImieEntry.Text, WiekEntry.Text, out wiadomosc))
            {
                PrzywitanieLabel.TextColor = Color.Red;
                PrzywitanieLabel.Text = wiadomosc;
                NiepelnoletnoscLabel.Text = "";
            }
            else
            {
                NiepelnoletnoscLabel.Text = WiekPelnoletni(WiekEntry.Text);
                PrzywitanieLabel.TextColor = Color.Green;
                NiepelnoletnoscLabel.TextColor = Color.Green;
                PrzywitanieLabel.Text = "Witaj " + Imie;
            }
            sprawdzBindowaniemButton.IsEnabled = false;
        }

        private void sprawdzBindowaniemButton_Clicked(object sender, EventArgs e)
        {
            
            string wiadomosc = "";
            if(!walidacja.WykonajWalidacje(Imie, Wiek,out wiadomosc))
            {
                Kolor = "Red";
                Przywitanie = wiadomosc;
                Niepelnoletnosc = "";
            }
            else
            {
                Niepelnoletnosc = WiekPelnoletni(Wiek);
                Kolor = "Green";
                Przywitanie = "Witaj " + Imie;
            }   
        }

        public string WiekPelnoletni(string wiek)
        {
            if (int.TryParse(wiek, out int wiekLiczba))
            {
                if (wiekLiczba >= 18)
                    return "Osoba jest pełnoletnia";
                else
                    return "Osoba jest niepełnoletnia";
            }
            else return "";
        }

    }
}
