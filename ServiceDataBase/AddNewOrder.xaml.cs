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
        public AddNewOrder(string loggedUser)
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
            this.loggedUser = loggedUser;
        }
        private bool confirmAction = false;
        private RowZlecenia rawRow = null;
        string loggedUser;


        //Zapytanie przy zamykaniu okna głownego programu
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            if (MessageBox.Show("Zamknąć okno programu?", "Pytanie", MessageBoxButton.OKCancel, MessageBoxImage.Asterisk) == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                return;
            }
            return;
        }


        private void Btn_anuluj_Click(object sender, RoutedEventArgs e)
        {
            confirmAction = false;
            this.Close();
        }

        private void Btn_dodaj_Click(object sender, RoutedEventArgs e)
        {
            confirmAction = true;
            rawRow = new RowZlecenia();

            if (!Int32.TryParse(tbx_numerZlecenia.Text, out int tmp1)) return;
            rawRow.numerZlecenia = tmp1;
            DateTime tmp = new DateTime();

            rawRow.nazwisko = tbx_nazwisko.Text;
            rawRow.status = cbx_status.SelectedItem.ToString();
            rawRow.koszt = 0;
            rawRow.model = tbx_ModelSprzetu.Text;
            rawRow.rodzajSprzetu = cbx_rodzajSprzetu.SelectedItem.ToString();
            rawRow.marka = cbx_markaSprzetu.SelectedItem.ToString();
            rawRow.dataPrzyjecia = DateTime.Now;
            rawRow.dataRozliczenia = tmp;
            rawRow.dataOdbioru = tmp;
            rawRow.dataZakonczenia = tmp;
            rawRow.kosztRobocizny = 0;
            rawRow.kosztMaterialu = 0;
            rawRow.kosztTransportu = 0;
            rawRow.rodzajNaprawy = cbx_rodzajNaprawy.SelectedItem.ToString();
            rawRow.miejscowosc = tbx_miejscowosc.Text;
            rawRow.kodPocztowy = tbx_kodPocztowy.Text;
            rawRow.adres = tbx_adres.Text;
            if (!Int32.TryParse(tbx_nip.Text, out int tmp2)) return;
            rawRow.nip = tmp2;
            if (!Int32.TryParse(tbx_telefon1.Text, out int tmp3)) return;
            rawRow.telefon1 = tmp3;
            if (!Int32.TryParse(tbx_telefon2.Text, out int tmp4)) return;
            rawRow.telefon2 = tmp4;
            rawRow.email = tbx_email.Text;
            rawRow.numerFabryczny = tbx_numerFabryczny.Text;
            rawRow.godzinaPrzyjecia = DateTime.Now;
            rawRow.numerRachunku = "brak";
            if (!double.TryParse(tbx_zaliczka.Text, out double tmp5)) return;
            rawRow.zaliczka = tmp5;
            rawRow.opis = tbx_usterka.Text;
            rawRow.user = loggedUser;
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

        public RowZlecenia getRowZlecenia() 
        { 
            return rawRow; 
        }

        public bool getConfirmAction() 
        { 
            return confirmAction; 
        }




    }
}
