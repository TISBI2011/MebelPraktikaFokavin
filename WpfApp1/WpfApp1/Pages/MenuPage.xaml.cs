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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BProfile_Click(object sender, RoutedEventArgs e)
        {

            //profileWindow.Show();
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void BSendMessage_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Вы отправили: " + TBMessage.Text);
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BMagazin_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MagazinPage());

        }
    }
}
