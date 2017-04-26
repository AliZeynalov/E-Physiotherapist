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
using System.Data.OleDb;
using System.Data;

namespace Wpf_doctor
{
   
    public class MyItem 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

       
    }
    
    public partial class DoctorWindow : Window
    {
       
        public DoctorWindow()
        {
           InitializeComponent();

            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader dr;
            
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users ";
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
               
                
                string a = dr["id"].ToString();
                int id = Int32.Parse(a);

                String name = dr["pname"].ToString();
                String mail = dr["mail"].ToString();
                String username = dr["username"].ToString();
                

                if (username != "admin")
                {
                    this.listView.Items.Add(new MyItem { Id = id, Name = name, Email = mail });
                    comboBox.Items.Add(name);

                }
                this.listView.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Id", System.ComponentModel.ListSortDirection.Ascending));
                
            }
            

            con.Close();
        }

        public void clear_Text()
        {
            nametxt.Clear();
            mailtxt.Clear();
            unametxt.Clear();
            passwdtxt.Clear();
            cpasswdtxt.Clear();
        }
        private void id_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= id_GotFocus;
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= id_GotFocus;
        }

        private void mail_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= id_GotFocus;
        }

        private void addbutton_Click(object sender, RoutedEventArgs e) 
        {
            OleDbConnection con;
            OleDbCommand cmd;
            

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            
            if (nametxt.Text != "" && mailtxt.Text != "" && unametxt.Text != "" && passwdtxt.Password != "" && cpasswdtxt.Password != "")
            {
                if(passwdtxt.Password == cpasswdtxt.Password)
                {
                    //cmd.CommandText = "insert into users(id,username,password,pname,mail) Values(" + idtxt.Text + ",'" + unametxt.Text + "','" + passwdtxt.Text + "'," + nametxt.Text + ",'" + mailtxt.Text + "')";
                    cmd.CommandText = "insert into users(username,upassword,pname,mail) Values('" + unametxt.Text + "','" + passwdtxt.Password + "','" + nametxt.Text + "','" + mailtxt.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Added Successfully...");
                    clear_Text();
                }
                else
                {
                    MessageBox.Show("You Must Confirm Your Password");
                }    
                        
            }
            else
            {
                MessageBox.Show("Please Be Sure That You Enter All Values!");
            }

            con.Close();
        }

        private void outbtn_Click(object sender, RoutedEventArgs e)
        {
            
            login_hatice.MainWindow win3 = new login_hatice.MainWindow();
            win3.Show();
            this.Close();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            shouldercb.IsChecked = false;
            armcb.IsChecked = false;
            kneecb.IsChecked = false;
            neckcb.IsChecked = false;
            hipcb.IsChecked = false;
            stretchcb.IsChecked = false;

            string selectedcmb = comboBox.SelectedItem.ToString();
            
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader dr;

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where pname ='"+ selectedcmb +"'";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string a = dr["id"].ToString();
                int id = Int32.Parse(a);
                String name = dr["pname"].ToString();
                String mail = dr["mail"].ToString();
                nametb.Text = name;
                mailtb.Text = mail;
                idtb.Text = a;
                if(dr["shoulder"].ToString() == "True")
                {
                    shouldercb.IsChecked = true;
                }
                if (dr["neck"].ToString() == "True")
                {
                    neckcb.IsChecked = true;
                }
                if (dr["arm"].ToString() == "True")
                {
                    armcb.IsChecked = true;
                }
                if (dr["knee"].ToString() == "True")
                {
                    kneecb.IsChecked = true;
                }
                if (dr["hip"].ToString() == "True")
                {
                    hipcb.IsChecked = true;
                }
                if (dr["stretch"].ToString() == "True")
                {
                    stretchcb.IsChecked = true;
                }
            }


            con.Close();
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            Boolean x1, x2, x3, x4, x5, x6;
            OleDbConnection con;
            OleDbCommand cmd;

            if(shouldercb.IsChecked == true)
            {
                x1 = true;
            }
            else
            {
                x1 = false;
            }
            if (kneecb.IsChecked == true)
            {
                x2 = true;
            }
            else
            {
                x2 = false;
            }
            if (neckcb.IsChecked == true)
            {
                x3 = true;
            }
            else
            {
                x3 = false;
            }
            if (armcb.IsChecked == true)
            {
                x4 = true;
            }
            else
            {
                x4 = false;
            }
            if (stretchcb.IsChecked == true)
            {
                x5 = true;
            }
            else
            {
                x5 = false;
            }
            if (hipcb.IsChecked == true)
            {
                x6 = true;
            }
            else
            {
                x6 = false;
            }


            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string selectedcmb = comboBox.SelectedItem.ToString();

            cmd.CommandText = "update users set [shoulder] = ?, [knee] = ?, [neck] = ?, [arm] = ?, [stretch] = ?, [hip] = ? where pname=? ";
            cmd.Parameters.AddWithValue("?", x1);
            cmd.Parameters.AddWithValue("?", x2);
            cmd.Parameters.AddWithValue("?", x3);
            cmd.Parameters.AddWithValue("?", x4);
            cmd.Parameters.AddWithValue("?", x5);
            cmd.Parameters.AddWithValue("?", x6);
            cmd.Parameters.AddWithValue("?", selectedcmb);
            cmd.ExecuteNonQuery();


            


            MessageBox.Show("Patient Motions Modified Successfully...");


            con.Close();
        }

        private void delbutton_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection con;
            OleDbCommand cmd;


            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string selectedcmb = comboBox.SelectedItem.ToString();
            cmd.CommandText = "delete from users where pname = '"+selectedcmb+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Deleted");
            
            con.Close();
        }
    }

        

      
}

