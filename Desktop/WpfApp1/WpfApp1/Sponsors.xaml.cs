using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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
    public partial class Sponsors : Window
    {
        private static int i = 0;
        private static int j = 1;
        private static int k = 2;
        private static string[] albums = new string[]
        {
            @"Backgrounds/sportzone.jpg",
            @"Backgrounds/ua.jpg",
            @"Backgrounds/zonaverde.png",
            @"Backgrounds/beiramar.png",
            @"Backgrounds/hospital.jpg"
        };

        public Sponsors()
        {
            InitializeComponent();
            Main.Source = new BitmapImage(new Uri(albums[j], UriKind.Relative));
            Right.Source = new BitmapImage(new Uri(albums[k], UriKind.Relative));
            Left.Source = new BitmapImage(new Uri(albums[i], UriKind.Relative));
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow win3 = new LoginWindow();
            win3.Show();
            this.Close();
        }

        private void AddNewMemberButton(object sender, RoutedEventArgs e)
        {
            AddNewMember win3 = new AddNewMember();
            win3.Show();
            this.Close();
        }

        private void RenewMemberButton(object sender, RoutedEventArgs e)
        {
            RenewMember win3 = new RenewMember();
            win3.Show();
            this.Close();
        }

        private void AccountClick(object sender, RoutedEventArgs e)
        {
            AccountWindow win3 = new AccountWindow();
            win3.Show();
            this.Close();
        }

        private void EventClick(object sender, RoutedEventArgs e)
        {
            Events win3 = new Events();
            win3.Show();
            this.Close();
        }

        private void SponsorsClick(object sender, RoutedEventArgs e)
        {
            Sponsors win3 = new Sponsors();
            win3.Show();
            this.Close();
        }

        private void ReunionsClick(object sender, RoutedEventArgs e)
        {
            ReunionsWindow win3 = new ReunionsWindow();
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

        private void ButtonSlideRight_Click(object sender, RoutedEventArgs e)
        {
            i--; j--; k--;
            if (i < 0) i = albums.Length - 1; if (j < 0) j = albums.Length - 1; if (k < 0) k = albums.Length - 1;
            Main.Source = new BitmapImage(new Uri(albums[j], UriKind.Relative));
            Right.Source = new BitmapImage(new Uri(albums[k], UriKind.Relative));
            Left.Source = new BitmapImage(new Uri(albums[i], UriKind.Relative));
        }

        private void ButtonSlideLeft_Click(object sender, RoutedEventArgs e)
        {
            i++; j++; k++;
            if (i >= albums.Length) i = 0; if (j >= albums.Length) j = 0; if (k >= albums.Length) k = 0;
            Main.Source = new BitmapImage(new Uri(albums[j], UriKind.Relative));
            Left.Source = new BitmapImage(new Uri(albums[k], UriKind.Relative));
            Right.Source = new BitmapImage(new Uri(albums[i], UriKind.Relative));
        }
    }
}
