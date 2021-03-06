﻿using System;
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
using Tulpep.NotificationWindow;

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
        {
            InitializeComponent();
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
            if (txtPassword1.Password == "" || txtPassword2.Password == "" || txtPassword3.Password == "") {
                label1.Content = "You must fill in all the fields!";
                label1.Visibility = Visibility.Visible;
            }
            else if (txtPassword1.Password == txtPassword2.Password) {
                label1.Content = "Your current password is equal to the new one!";
                label1.Visibility = Visibility.Visible;
            }
            else if (txtPassword2.Password == txtPassword3.Password) {
                label1.Content = "New password doesn't match to its confirmation!";
                label1.Visibility = Visibility.Visible;
            }
            else {
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "";
                popup.ContentText = "Password updated successfuly!";
                popup.Popup();
                HomeWindow win = new HomeWindow();
                win.Show();
                this.Close();
            }
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

        private void Enter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Confirm.Focus();
                AccountClick(sender, null);
            }
        }

    }
}
