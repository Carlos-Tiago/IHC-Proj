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
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, RoutedEventArgs e) {
        }
        private void Button1_MouseHover(object sender, RoutedEventArgs e)
        {
            this.mygrid.Width = 525;
            this.mygrid.Height = 380;
        }

        private void Button_MouseLeave(object sender, RoutedEventArgs e)
        {

        }
    }
}
