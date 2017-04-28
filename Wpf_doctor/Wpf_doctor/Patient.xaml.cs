using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net.Mail;
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
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class Patient : Window
    {
        public Patient(String _mainusername)
        {
            InitializeComponent();
            String username = _mainusername;
            OleDbConnection con;
            OleDbCommand cmd;
            OleDbDataReader dr;

            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users where username ='" + username + "'";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {


                String name = dr["pname"].ToString();
                String mail = dr["mail"].ToString();
                string a = dr["id"].ToString();
                int id = Int32.Parse(a);
                nametb.Text = name;
                idtb.Text = id.ToString();
                mailtb.Text = mail;


            }
        }

        private void enablebtn_Click(object sender, RoutedEventArgs e)
        {
            if (mailtb.IsEnabled == true)
            {
                mailtb.IsEnabled = false;
                mailtb.IsReadOnly = true;
            }
            else
            {
                mailtb.IsEnabled = true;
                mailtb.IsReadOnly = false;
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (mailtb.IsEnabled == true)
            {
                
                OleDbConnection con;
                OleDbCommand cmd;
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;



                string nmail = mailtb.Text;
                string pname = nametb.Text;

                cmd.CommandText = "update users set [mail] = ? where pname=? ";
                cmd.Parameters.AddWithValue("?", nmail);
                cmd.Parameters.AddWithValue("?", pname);
                cmd.ExecuteNonQuery();

                MessageBox.Show("E-Mail Updated");

                con.Close();
            }
            else
            {
                MessageBox.Show("You must enable mail area to update your mail account!");
            }
            
        }

        private void sendbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OleDbConnection con;
                OleDbCommand cmd;
                OleDbDataReader dr;

                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=login.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM users";
                dr = cmd.ExecuteReader();
                String adminmail = "";
                while (dr.Read())
                {
                    String username = dr["username"].ToString();
                    if (username == "admin")
                    {
                        adminmail = dr["mail"].ToString();
                    }

                }
                var subj = subjecttb.Text;
                var msg = msgtb.Text;
                var from = mailtb.Text;
                var to = adminmail;
                var pass = passtb.Password;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(from);
                mail.To.Add(to);
                mail.Subject = subj;

                StringBuilder sbBody = new StringBuilder();

                sbBody.AppendLine(msg);

                mail.Body = sbBody.ToString();


                SmtpServer.Credentials = new System.Net.NetworkCredential(from, pass);
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;



                SmtpServer.Send(mail);

                MessageBox.Show("Mail Sended to " + to + "");

                msgtb.Clear();
                subjecttb.Clear();
                passtb.Clear();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check Your Password");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Wpf_doctor.Auth win8 = new Wpf_doctor.Auth();
            win8.Show();
            this.Close();
        }
    }
}
