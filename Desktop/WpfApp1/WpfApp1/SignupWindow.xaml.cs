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

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para SignupWindow.xaml
    /// </summary>
    public partial class SignupWindow : Window
    {
        public SignupWindow()
        {
            InitializeComponent();
        }

        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmail.Text == "" || txtUsername.Text == "")
            {
                label1.Content = "Invalid Username and/or Email!";
                label1.Visibility = Visibility.Visible;
            }
            else if (txtPassword.Password != txtPassword2.Password)
            {
                label1.Content = "Passwords don't match!";
                label1.Visibility = Visibility.Visible;
            }
            else {
                LoginWindow win = new LoginWindow();
                win.Show();
                this.Close();
            } 
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Signed.Focus();
                ButtonSignUp_Click(sender, null);
            }
        }
    }
}
