using System;
using System.Collections.Generic;
using System.Text;

namespace WalidacjaDanychApp
{
    class WalidacjaImienia
    {
        private bool SprawdzImiePuste(string imie, out string wiadomosc)
        {
            if (!string.IsNullOrWhiteSpace(imie))
            {
                wiadomosc = "";
                return true;
            }
            else
                wiadomosc = "Puste imie.";
            return false;
        }

        private bool SprawdzPoprawnoscImienia(string imie, out string wiadomosc)
        {
            wiadomosc = "";
            if (imie == null)
            {
                wiadomosc = "Nie podano imienia";
                return false;
            }

            foreach (char znak in imie)
            {
                if (!((znak >= 'a' && znak <= 'z') || (znak >= 'A' && znak <= 'Z')))
                {
                    wiadomosc = "Imie jest niepoprawne";
                    return false;
                }
            }
            return true;
        }

        public bool Zwaliduj(string imie, out string wiadomosc)
        {
            if (!SprawdzImiePuste(imie, out wiadomosc))
                return false;
            if (!SprawdzPoprawnoscImienia(imie, out wiadomosc))
                return false;
            wiadomosc = "";
            return true;
        }
    }
}
