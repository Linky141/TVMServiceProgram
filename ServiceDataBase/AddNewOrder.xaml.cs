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
            rawRow.numerFabryczny = tbx_numerFabryczny.Text;
            rawRow.uwagi = tbx_uwagi.Text;
            rawRow.opis = tbx_usterka.Text;
            rawRow.przewodZasilajacy = (bool) chkbx_przewodZasilajacy.IsChecked;
            rawRow.pilot = (bool) chkbx_pilot.IsChecked;
            rawRow.podstawa = (bool) chkbx_podstawa.IsChecked;
            rawRow.wieszak = (bool) chkbx_wieszak.IsChecked;
            rawRow.opakowanie = (bool) chkbx_opakowanie.IsChecked;
            rawRow.przywoz = (bool) chkbx_przywoz.IsChecked;
            rawRow.status = cbx_status.SelectedItem.ToString();
            rawRow.rodzajNaprawy = cbx_rodzajNaprawy.SelectedItem.ToString();
            rawRow.rodzajSprzetu = cbx_rodzajSprzetu.SelectedItem.ToString();
            rawRow.marka = cbx_markaSprzetu.SelectedItem.ToString();
            rawRow.model = tbx_ModelSprzetu.Text;
            rawRow.nazwisko = tbx_nazwisko.Text;
            rawRow.kodPocztowy = tbx_kodPocztowy.Text;
            rawRow.miejscowosc = tbx_miejscowosc.Text;
            

            this.Close();
        }
    }
}
