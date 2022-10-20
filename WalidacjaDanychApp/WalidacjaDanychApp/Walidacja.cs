using System;
using System.Collections.Generic;
using System.Text;

namespace WalidacjaDanychApp
{
    public class Walidacja
    {
        WalidacjaImienia walidacjaImienia = new WalidacjaImienia();
        WalidacjaWieku walidacjaWieku = new WalidacjaWieku();
        public bool WykonajWalidacje(string imie, string wiek, out string wiadomosc)
        {
            if(!walidacjaImienia.Zwaliduj(imie, out wiadomosc) ||
               !walidacjaWieku.Zwaliduj(wiek, out wiadomosc))
            {
                return false;
            }
            else
            {
                wiadomosc = "";
                return true;
            }
            
        }
    }
}
