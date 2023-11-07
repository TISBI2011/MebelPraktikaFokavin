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
    /// Логика взаимодействия для MagazinPage.xaml
    /// </summary>
    public partial class MagazinPage : Page
    {
        public MagazinPage()
        {
            InitializeComponent();
            DGMagazin.ItemsSource = App.DB.Mebel.ToList();
        }
    }
}
