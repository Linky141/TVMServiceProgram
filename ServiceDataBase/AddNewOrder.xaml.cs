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

       

        private void Btn_anuluj_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
