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
using System.Windows.Shapes;

namespace Wpf_doctor
{
    /// <summary>
    /// Interaction logic for DefineMotion.xaml
    /// </summary>
    public partial class DefineMotion : Window
    {
        public DefineMotion()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            Wpf_doctor.DoctorWindow win5 = new Wpf_doctor.DoctorWindow();
            win5.Show();
            this.Close();
        }
    }
}
