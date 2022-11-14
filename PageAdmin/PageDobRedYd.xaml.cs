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
    /// Логика взаимодействия для PageDobRedYd.xaml
    /// </summary>
    public partial class PageDobRedYd : Page
    {
        public PageDobRedYd()
        {
            InitializeComponent();
            DGridSport.ItemsSource = sporttovarEntities.GetContext().tovar.ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
            
        }

       private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var tovarForRemoving = DGridSport.SelectedItems.Cast<tovar>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие { tovarForRemoving.Count() } элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)

            {
                try
                {
                    sporttovarEntities.GetContext().tovar.RemoveRange(tovarForRemoving);
                    sporttovarEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridSport.ItemsSource = sporttovarEntities.GetContext().tovar.ToList();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new AddEditPage(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
 
        }
   
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new AddEditPage((sender as Button).DataContext as tovar));

        }
        
                private void Page_IsVisibleChanged_1(object sender, DependencyPropertyChangedEventArgs e)
                {
                    if (Visibility == Visibility.Visible)
                    {
                        sporttovarEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                        DGridSport.ItemsSource = sporttovarEntities.GetContext().tovar.ToList();
                    }
                }

                private void BtnDelete_Click_1(object sender, RoutedEventArgs e)
                {

                }
        
    }

}
