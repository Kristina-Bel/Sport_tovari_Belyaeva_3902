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


namespace Sport_tovari_Belyaeva_3902.Pagemain
{
    /// <summary>
    /// Логика взаимодействия для PageCreateAcc.xaml
    /// </summary>
    public partial class PageCreateAcc : Page
    {
        public PageCreateAcc()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.GoBack();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        { if (txbLogin.Text=="")
            {
                MessageBox.Show("введите логин!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
        else
            if (AppConnect.modelOdb.User.Count(x => x.Login == txbLogin.Text) > 0)
            {
                MessageBox.Show("Пользователь с таким логином есть!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
           
            try
                
                {
                    User userObj = new User();
                    {
                        userObj.Login = txbLogin.Text;
                        userObj.FIO = txbName.Text;
                        userObj.Password = txbPass.Text;
                        userObj.IDrole = 3;
                    };
                    AppConnect.modelOdb.User.Add(userObj);
                    AppConnect.modelOdb.SaveChanges();
                    MessageBox.Show("Данные успешно добавлены!",
                        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (psbPass.Password != txbPass.Text)
            {
                btnCreate.IsEnabled = false;
                psbPass.Background = Brushes.LightCoral;
                psbPass.BorderBrush = Brushes.Red;
            }
            else
            {
                btnCreate.IsEnabled = true;
                psbPass.Background = Brushes.LightGreen;
                psbPass.BorderBrush = Brushes.Green;
            }
        }
    }
    }


