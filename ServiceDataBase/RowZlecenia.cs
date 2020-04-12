using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataBase
{

    //klasa ze zmiennymi do tabeli ZLECENIA

    public class RowZlecenia
    {
        public int numerZlecenia{ get; set; }

        public string nazwisko{ get; set; }

        public string status{ get; set; }

        public double koszt{ get; set; }

        public string model{ get; set; }

        public string rodzajSprzetu{ get; set; }

        public string marka{ get; set; }

        public DateTime dataPrzyjecia{ get; set; }

        public DateTime dataRozliczenia{ get; set; }

        public DateTime dataOdbioru{ get; set; }

        public DateTime dataZakonczenia{ get; set; }

        public double kosztRobocizny{ get; set; }

        public double kosztMaterialu{ get; set; }

        public double kosztTransportu{ get; set; }

        public string rodzajNaprawy{ get; set; }

        public string miejscowosc{ get; set; }

        public string kodPocztowy{ get; set; }

        public string adres{ get; set; }

        public int nip{ get; set; }

        public int telefon1{ get; set; }

        public int telefon2{ get; set; }

        public string email{ get; set; }

        public string numerFabryczny{ get; set; }

        public DateTime godzinaPrzyjecia{ get; set; }

        public string numerRachunku{ get; set; }

        public double zaliczka{ get; set; }

        public string opis{ get; set; }

        public string user{ get; set; }

        public bool Zamkniete{ get; set; }

        public bool przywoz{ get; set; }

        public bool pilot{ get; set; }

        public bool przewodZasilajacy{ get; set; }
    
        public bool podstawa{ get; set; }

        public bool wieszak{ get; set; }

        public bool opakowanie{ get; set; }

        public string uwagi{ get; set; } 
    }
}
