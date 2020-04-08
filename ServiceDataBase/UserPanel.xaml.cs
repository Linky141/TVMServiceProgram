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
    /// Logika interakcji dla klasy UserPanel.xaml
    /// </summary>
    public partial class UserPanel : Window
    {
        /*
         * inicjalizacja zmiennych
         * */
        Users user;
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();


        public UserPanel(Users _user)
        {
            InitializeComponent();
            user = _user;
            SetUserPermissions();
            lbl_loggedUserName.Content = user.getLogin();
            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        /*
         * obsługa zdarzeń
         */



        private void btn_new_Click(object sender, RoutedEventArgs e)
        {
            AddNewOrder addNewOrder = new AddNewOrder();
            addNewOrder.ShowDialog();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_sort_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_double_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_print_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F12) this.Close();
        }

        /*
         * inne metody
         */

        private void SetUserPermissions()
        {

        }

        private void Timer_Click(object sender, EventArgs e)

        {

            DateTime d;

            d = DateTime.Now;

            lbl_clock.Content = d.ToString("HH:mm");
            lbl_clockSeconds.Content = d.ToString("ss");
            lbl_clockDate.Content = d.ToString("dd - MM - yyyy");
            lbl_clockDateDayOfWeek.Content = d.ToString("dddd");
        }

    }
}
