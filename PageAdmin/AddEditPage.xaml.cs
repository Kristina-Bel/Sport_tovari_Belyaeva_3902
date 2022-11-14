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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private tovar _currentTovar = new tovar();  
        public AddEditPage(tovar selectedTovar)
        {
            
            InitializeComponent();


            if (selectedTovar != null)
                _currentTovar = selectedTovar;


            DataContext  = _currentTovar;
            ComboK.ItemsSource = sporttovarEntities.GetContext().kategorya.ToList();    
            ComboP.ItemsSource = sporttovarEntities.GetContext().Postavchik.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentTovar.idtovar == 0)
            {

                sporttovarEntities.GetContext().tovar.Add(_currentTovar);
            }
            try
            {
                sporttovarEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
