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
namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Password == "") {
                label1.Content = "Invalid Username and/or Password!";
                label1.Visibility = Visibility.Visible;
            }
            else {
                HomeWindow win2 = new HomeWindow();
                win2.Show();
                this.Close();
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            SignupWindow win4 = new SignupWindow();
            win4.Show();
            this.Close();
        }

        private void Enter(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                LoginButton.Focus();
                ButtonLogin_Click(sender, null);
            }
        }
    }
}
