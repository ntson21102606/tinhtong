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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int tong = 0, tongChan = 0, tongLe = 0, n = 0;

            if (textBox.Text.Equals(""))
            {
                n = 0;
            }
            else
            {
                n = int.Parse(textBox.Text);
            }

            if (radioButton.IsChecked == true)
            {
                for (int i = 0; i <= n; i++)
                {
                    tong += i;
                }

                txblHienThi.Text = tong.ToString();
            }
            else if (radioButton1.IsChecked == true)
            {
                for (int i = 0; i <= n; i += 2)
                {
                    tongChan += i;
                }

                txblHienThi.Text = tongChan.ToString();
            }
            else if (radioButton2.IsChecked == true)
            {
                for (int i = 1; i <= n; i += 2)
                {
                    tongLe += i;
                }

                txblHienThi.Text = tongLe.ToString();
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
