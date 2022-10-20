using System;
using System.Collections.Generic;
using System.Text;

namespace WalidacjaDanychApp
{
    class WalidacjaWieku
    {
        private bool CzyWiekPusty(string wiek, out string wiadomosc)
        {
            if (!string.IsNullOrWhiteSpace(wiek))
            {
                wiadomosc = "";
                return true;
            }
            else
            {
                wiadomosc = "wiek jest pusty.";
                return false;
            }
        }

        private bool CzyPoprawnyWiek(string wiek, out string wiadomosc)
        {
            int wiekLiczba;
            bool czyPrawdziwyWiek = int.TryParse(wiek, out wiekLiczba);
            wiadomosc = "";
            if (!czyPrawdziwyWiek)
            {
                wiadomosc = "Niepoprawny wiek.";
            }
            return czyPrawdziwyWiek;
        }

        private bool ZakresPodawanyPrzezUzytkownika(string wiek, out string wiadomosc)
        {
            int wiekInt = int.Parse(wiek);
            if(wiekInt  >= 0 && wiekInt <= 150)
            {
                wiadomosc = "Wiek poprawny";
                return true;
            }
            else
            {
                wiadomosc = "Wiek niepoprawny";
                return false;
            }    
        }

        public bool Zwaliduj(string wiek, out string wiadomosc)
        {
            if (!CzyWiekPusty(wiek, out wiadomosc))
                return false;
            if (!CzyPoprawnyWiek(wiek, out wiadomosc))
                return false;
            if (!ZakresPodawanyPrzezUzytkownika(wiek, out wiadomosc))
                return false;
            wiadomosc = "";
            return true;
        }
    }
}
