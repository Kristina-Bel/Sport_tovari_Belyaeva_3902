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
using Sport_tovari_Belyaeva_3902.ApplicationData;

namespace Sport_tovari_Belyaeva_3902.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageMenuAdmin.xaml
    /// </summary>
    public partial class PageMenuAdmin : Page
    {
        public PageMenuAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                    }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private void sp_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageSp());
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new PageDobRedYd());
        }
    }
}
