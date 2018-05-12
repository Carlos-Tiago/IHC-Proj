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
using System.Diagnostics;
using System.Windows.Navigation;
using System.Windows.Controls.Primitives;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow win3 = new LoginWindow();
            win3.Show();
            this.Close();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void GitHubRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void GitHubItemSelected(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Carlos-Tiago/IHC-Proj"));
        }

        private void HomeItemSelected(object sender, RoutedEventArgs e)
        {
            HomeWindow win3 = new HomeWindow();
            win3.Show();
            this.Close();
        }
        private void TestItemSelected(object sender, RoutedEventArgs e)
        {
            Popup myPopup = new Popup();
            myPopup.IsOpen = true;
            
        }

        private void OrganizationItemSelected(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
