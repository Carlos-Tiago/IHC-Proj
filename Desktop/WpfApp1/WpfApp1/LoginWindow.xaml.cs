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
            this.DataContext = this;
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow win2 = new HomeWindow();
            win2.Show();
            this.Close();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            SignupWindow win4 = new SignupWindow();
            win4.Show();
            this.Close();
        }
    }

    public class EmailValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if ((String)value == "")
                return new ValidationResult(false, "value cannot be empty.");
            else if((String)value != "carlos") {
                return new ValidationResult(false, "value has to be carlos");
            }
            return ValidationResult.ValidResult;
        }
    }
}