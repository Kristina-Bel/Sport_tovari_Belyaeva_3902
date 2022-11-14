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

namespace Sport_tovari_Belyaeva_3902
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.modelOdb = new sporttovarEntities();
            AppFrame.frameMain = FrmMain;
            FrmMain.Navigate(new Pagemain.PageLogin());
            
        
        }



        private void FrmMain_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
