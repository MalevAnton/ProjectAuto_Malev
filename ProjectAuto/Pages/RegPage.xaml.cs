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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();

            cbRole.ItemsSource = BaseClass.tME.Table_Roles.ToList();
            cbRole.SelectedValuePath = "idRole";
            cbRole.DisplayMemberPath = "role";
            cbRole.SelectedIndex = 1;
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            int g = 0;
            if (rbMen.IsChecked == true) g = 1;
            if (rbWomen.IsChecked == true) g = 2;

            Table_Mastera table_Mastera = new Table_Mastera()
            {
                surname = tboxSurname.Text,
                name = tboxName.Text,
                fatherland = tboxFatherland.Text,
                birthday = Convert.ToDateTime(dpBirthday.SelectedDate),
                login = tboxLogin.Text,
                password = pbPassword.Password.GetHashCode(),
                idGender = g,
                idRole = cbRole.SelectedIndex + 1,
            };

            BaseClass.tME.Table_Mastera.Add(table_Mastera);
            BaseClass.tME.SaveChanges();
            MessageBox.Show("Пользователь добавлен");
            FrameClass.MainFrame.Navigate(new MainPage());
        }

        private void btnBackMain_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new MainPage());
        }
    }
}
