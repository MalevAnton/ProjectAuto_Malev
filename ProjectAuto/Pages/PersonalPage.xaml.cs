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
    /// Логика взаимодействия для PersonalPage.xaml
    /// </summary>
    public partial class PersonalPage : Page
    {
        private Table_Mastera mastera;

        public PersonalPage()
        {
            InitializeComponent();

        }

        public PersonalPage(Table_Mastera table_Mastera)
        {
            this.mastera = table_Mastera;
        }
    }

    
}
