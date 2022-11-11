using ProjectAuto.Classes;
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

namespace ProjectAuto.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutoPage.xaml
    /// </summary>
    public partial class AutoPage : Page
    {
        public AutoPage()
        {
            InitializeComponent();
        }

        private void btnBackMain_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new MainWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int p = pbRassword.Password.GetHashCode();

            Table_Mastera table_Mastera = BaseClass.tME.Table_Mastera.FirstOrDefault(x => x.login == tboxLogin.Text && x.password == p);

            if (table_Mastera == null)
            {
                MessageBox.Show("Пользователя не существует");
            }    
            else
            {
                switch(table_Mastera.idRole)
                {
                    case 1:
                        FrameClass.MainFrame.Navigate(new AdminPage(table_Mastera));
                    break;
                    
                    case 2:
                        FrameClass.MainFrame.Navigate(new PersonalPage(table_Mastera));
                    break;
                    
                    default:
                        MessageBox.Show("Пока");
                    break;
                }
            }    
        }
    }
}
