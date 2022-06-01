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

namespace MPK
{
    /// <summary>
    /// Логика взаимодействия для Autoriz.xaml
    /// </summary>
    public partial class Autoriz : Window
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Autoriz()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usr = txtUser.Text;
            string psw = txtPass.Password;
            con = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source=magazine.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT * FROM tblUser where user='" + txtUser.Text + "' AND pass='" + txtPass.Password + "'";
            cmd.CommandText = str;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Добро пожаловать " + txtUser.Text);
                this.Hide();
                MainWindow win0 = new MainWindow();
                win0.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

            con.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reg win2 = new Reg();
            win2.Show();
        }
    }
}
