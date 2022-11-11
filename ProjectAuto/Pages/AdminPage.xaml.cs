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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        Table_Mastera mastera;

        public AdminPage(Table_Mastera mastera)
        {
            InitializeComponent();
            this.mastera = mastera;
            dgMastera.ItemsSource = BaseClass.tME.Table_Mastera.ToList();
        }

        private void btnShowMaster_Click(object sender, RoutedEventArgs e) // кнопка для просмотра пользователей в таблице
        {
            dgMastera.Visibility = Visibility.Visible;
            btnShowMaster.Visibility = Visibility.Collapsed;
            btnPrivateMaster.Visibility = Visibility.Visible;
        }

        private void btnPrivateMaster_Click(object sender, RoutedEventArgs e)  // кнопка для скрытия таблицы
        {
            dgMastera.Visibility = Visibility.Collapsed;
            btnShowMaster.Visibility = Visibility.Visible;
            btnPrivateMaster.Visibility = Visibility.Collapsed;
        }

        private void btnmain_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new MainPage());
        }

        private void btnShowAuto_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new ShowAutoPage());
        }

        private void btnPersonal_Click(object sender, RoutedEventArgs e)   // переход в личный кабинет
        {
            FrameClass.MainFrame.Navigate(new PersonalPage(mastera));
        }
    }
}
