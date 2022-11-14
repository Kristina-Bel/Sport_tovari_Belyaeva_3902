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
    /// Логика взаимодействия для PageSp.xaml
    /// </summary>
    public partial class PageSp : Page
    {
        public PageSp()
        {
            InitializeComponent();
            var currentSport = sporttovarEntities.GetContext().tovar.ToList();
            
            LViewTovar.ItemsSource = currentSport;
            var allP = sporttovarEntities.GetContext().Postavchik.ToList();
            allP.Insert(0, new Postavchik
            {
                Postavchik1 = "Все поставщики"
            });
            ComboP.ItemsSource = allP;
            ComboP.SelectedIndex = 0;

           
        }

        private void UpdateTovar()
        {
            var currentSport = sporttovarEntities.GetContext().tovar.ToList();
            if (ComboP.SelectedIndex > 0)
                currentSport = currentSport.Where(p => p.IDpostavchil==ComboP.SelectedIndex).ToList();
            currentSport = currentSport.Where(p => p.name.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();


            LViewTovar.ItemsSource = currentSport;
        }
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTovar();
        }

        private void ComboP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTovar();
        }
    }
}
