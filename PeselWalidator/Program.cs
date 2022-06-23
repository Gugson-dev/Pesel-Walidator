using System.Text.RegularExpressions;
using System;

namespace PeselWalidator
{
    public class PESELWalidator
    {
        protected int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        protected string pesel;

        static void Main(){}

        public PESELWalidator(String pesel)
        {
            WczytajPesel(pesel);
        }

        public void WczytajPesel(String pesel)
        {

            this.pesel = pesel;

        }

        public int SumaKontrolna()
        {
            int suma = 0;

            for (int i = 0; i < pesel.Length - 1; i++)
            {
                suma += Int32.Parse(pesel[i].ToString()) * wagi[i];
            }

            return 10 - (suma % 10) % 10;
        }

        public String DataUrodzenia()
        {
            return pesel[..6];
        }

        public String Plec()
        {

            if (pesel[pesel.Length - 2] % 2 == 0)
            {
                return "Kobieta";
            }
            else
                return "Mezczyzna";
        }

        public Boolean SprawdzPesel()
        {
            string pattern = @"^[0-9]{11}$";
            return Regex.Match(pesel, pattern).Value.Length == 11;
        }
    }
}