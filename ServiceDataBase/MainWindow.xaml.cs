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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ServiceDataBase
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         * inicjalizacja zmiennych
         * */
        List<Users> users = new List<Users>();


        public MainWindow()
        {
            InitializeComponent();
            if (users.Count == 0) users.Add(new Users("", "", true, true, true, true));
            tbx_login.Focus();
        }


        /*
         * obsługa zdarzeń
         * */

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if(CheckExistingUserInList(tbx_login.Text, tbx_password.Text))
            {
                UserPanel userPanel = new UserPanel(GetUserFromList(tbx_login.Text, tbx_password.Text));
                tbx_login.Clear();
                tbx_password.Clear();
                userPanel.ShowDialog();
                tbx_login.Focus();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania");
            }
        }

        private void tbx_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return) btn_login_Click(sender, e);
            else if (e.Key == Key.Escape) this.Close();
        }

        private void tbx_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return) btn_login_Click(sender, e);
            else if (e.Key == Key.Escape) this.Close();
        }

        private void Btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /*
         * inne metody
         * */

        private bool CheckExistingUserInList(string login, string password)
        {
            foreach(Users user in users)
            {
                if (user.getLogin() == login && user.getPassword() == password) return true;
            }
            return false;
        }

        private Users GetUserFromList(string login, string password)
        {
            foreach (Users user in users)
            {
                if (user.getLogin() == login && user.getPassword() == password) return user;
            }
            return null;
        }



    }
}
