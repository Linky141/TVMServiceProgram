using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
namespace ServiceDataBase
{
    /// <summary>
    /// Logika interakcji dla klasy AddNewOrder.xaml
    /// </summary>
    public partial class AddNewOrder : Window
    {
        public AddNewOrder()
        {
            InitializeComponent();
            ComboboxesItemsData comboboxesItemsData = new ComboboxesItemsData();
            cbx_status.ItemsSource = comboboxesItemsData.FillStatusCombobox(1);
            cbx_status.SelectedItem = "Do naprawy";
            cbx_rodzajNaprawy.ItemsSource = comboboxesItemsData.FillRodzajNaprawyCombobox();
            cbx_rodzajNaprawy.SelectedItem = "Warsztatowa";
            cbx_rodzajSprzetu.ItemsSource = comboboxesItemsData.FillRodzajSprzetuCombobox();
            cbx_rodzajSprzetu.SelectedIndex = 0;
            cbx_markaSprzetu.ItemsSource = comboboxesItemsData.FillMarkaSprzetuCombobox();
            cbx_markaSprzetu.SelectedIndex = 0;
        }
        public bool confirmAction = false;
       public RowZlecenia rawRow = null;

        private void Btn_anuluj_Click(object sender, RoutedEventArgs e)
        {
            confirmAction = false;
            this.Close();
        }

        private void Btn_dodaj_Click(object sender, RoutedEventArgs e)
        {
            confirmAction = true;
            rawRow = new RowZlecenia();

            if (!Int32.TryParse(tbx_numerZlecenia.Text, out rawRow.numerZlecenia)) return;
            rawRow.nazwisko = tbx_nazwisko.Text;
            rawRow.status = cbx_status.SelectedItem.ToString();
            rawRow.koszt = 0;
            rawRow.model = tbx_ModelSprzetu.Text;
            rawRow.rodzajSprzetu = cbx_rodzajSprzetu.SelectedItem.ToString();
            rawRow.marka = cbx_markaSprzetu.SelectedItem.ToString();
            //rawRow.dataPrzyjecia = 
            //rawRow.dataRozliczenia = 
            //rawRow.dataOdbioru = 
            //rawRow.dataZakonczenia = 
            //rawRow.kosztRobocizny = 
            //rawRow.kosztMaterialu = 
            //rawRow.kosztTransportu = 
            rawRow.rodzajNaprawy = cbx_rodzajNaprawy.SelectedItem.ToString();
            rawRow.miejscowosc = tbx_miejscowosc.Text;
            rawRow.kodPocztowy = tbx_kodPocztowy.Text;
            rawRow.adres = tbx_adres.Text;
            if (!Int32.TryParse(tbx_nip.Text, out rawRow.nip)) return;
            if (!Int32.TryParse(tbx_telefon1.Text, out rawRow.telefon1)) return;
            if (!Int32.TryParse(tbx_telefon2.Text, out rawRow.telefon2)) return; 
            rawRow.email = tbx_email.Text;
            rawRow.numerFabryczny = tbx_numerFabryczny.Text;
            //rawRow.godzinaPrzyjecia = 
            rawRow.numerRachunku = "brak";
            if (!double.TryParse(tbx_zaliczka.Text, out rawRow.zaliczka)) return;
            rawRow.opis = tbx_usterka.Text;
            //rawRow.user = wpisać zalogowanego
            rawRow.Zamkniete = false;
            rawRow.przywoz = (bool)chkbx_przywoz.IsChecked;
            rawRow.pilot = (bool)chkbx_pilot.IsChecked;
            rawRow.przewodZasilajacy = (bool)chkbx_przewodZasilajacy.IsChecked;
            rawRow.podstawa = (bool)chkbx_podstawa.IsChecked;
            rawRow.wieszak = (bool)chkbx_wieszak.IsChecked;
            rawRow.opakowanie = (bool)chkbx_opakowanie.IsChecked;
            rawRow.uwagi = tbx_uwagi.Text;

            this.Close();
        }
    }
}
