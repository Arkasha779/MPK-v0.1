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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=magazine.mdb;";
        private OleDbConnection myConnection;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Autoriz win1 = new Autoriz();
            win1.Show();
        }
        public OleDbDataReader Select(string selectSQL)                 // функция подключения к базе данных и обработка запросов
        {
            string connection = (@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=magazine.mdb"); // путь к базе данных
            OleDbConnection connect = new OleDbConnection(connection);  // подключаемся к базе данных
            connect.Open();                                             // открываем базу данных

            OleDbCommand cmd = new OleDbCommand(selectSQL, connect);    // создаём запрос
            OleDbDataReader reader = cmd.ExecuteReader();               // получаем данные

            return reader;                                              // возвращаем
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text.Length == 0 & TextBox2.Text.Length == 0 & TextBox3.Text.Length == 0 & TextBox4.Text.Length == 0 & TextBox5.Text.Length == 0 & TextBox6.Text.Length == 0)
                {
                    MessageBox.Show("Не все данные введены!", "Внимание!");
                    return;
                }

            else {
                OleDbDataReader read = Select("SELECT * FROM tblUser");
                Select("INSERT INTO tblUser([user], [pass], [name], [secname], [patr], [adress]) VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "')");
                //string user = TextBox1.Text;
                //string pass = TextBox2.Text;
                //string name = TextBox3.Text;
                //string secname = TextBox4.Text;
                //string patr = TextBox5.Text;
                //string adress = TextBox6.Text;

                //string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=magazine.mdb";
                //OleDbConnection dbConnection = new OleDbConnection(connectionString);


                //dbConnection.Open();
                //string query = "INSERT INTO tblUser VALUES ('" + user + "', '" + pass + "','" + name + "','" + secname + "','" + patr + "','" + adress + "')";
                //OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);


                //if (dbCommand.ExecuteNonQuery() != 1)
                //    MessageBox.Show("Вы не зарегистрированы!");
                //else
                //    MessageBox.Show("Вы зарегистрированы!");
                this.Hide();
                MainWindow win0 = new MainWindow();
                win0.Show();


                //dbConnection.Close();
            }
        }
    }
}
