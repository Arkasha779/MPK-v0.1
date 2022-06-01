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

namespace MPK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void img1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            MainWindow win0 = new MainWindow();
            win0.Show();
        }

        private void img2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            MainWindow win0 = new MainWindow();
            win0.Show();
        }

        private void img3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            MainWindow win0 = new MainWindow();
            win0.Show();
        }
    }
}
