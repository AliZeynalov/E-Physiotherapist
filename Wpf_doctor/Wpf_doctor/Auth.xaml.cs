using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
    /// Interaction logic for Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader dr;
            String name = usernametb.Text;
            String password = passtb.Password;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where username='" + usernametb.Text + "' AND upassword='" + passtb.Password + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                String username = dr["username"].ToString();
                if (username == "admin")
                {
                    Wpf_doctor.DoctorWindow win2 = new Wpf_doctor.DoctorWindow();
                    win2.Show();
                    this.Close();
                }
                else
                {
                    string mainusername = username;
                    Wpf_doctor.Patient win6 = new Wpf_doctor.Patient(mainusername);
                    win6.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            con.Close();
        }
    }
}
