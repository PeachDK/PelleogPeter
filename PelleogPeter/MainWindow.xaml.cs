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

namespace PelleogPeter
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

        private void scroll_up_Click(object sender, RoutedEventArgs e)
        {
            string placeholder0 = textBox0.Text;
            string placeholder2 = textBox2.Text;
            string placeholder3 = textBox3.Text;
            string placeholder4 = textBox4.Text;

            textBox0.Text = placeholder2;
            textBox2.Text = placeholder3;
            textBox3.Text = placeholder4;
            textBox4.Text = placeholder0;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBox0.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void scroll_down_Click(object sender, RoutedEventArgs e)
        {
            string placeholder0 = textBox0.Text;
            string placeholder2 = textBox2.Text;
            string placeholder3 = textBox3.Text;
            string placeholder4 = textBox4.Text;

            textBox0.Text = placeholder4;
            textBox2.Text = placeholder0;
            textBox3.Text = placeholder2;
            textBox4.Text = placeholder3;
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            

            for (int i = 1; i < random.Next(1,20); i++)
            {
                string placeholder0 = textBox0.Text;
                string placeholder2 = textBox2.Text;
                string placeholder3 = textBox3.Text;
                string placeholder4 = textBox4.Text;

                textBox0.Text = placeholder4;
                textBox2.Text = placeholder0;
                textBox3.Text = placeholder2;
                textBox4.Text = placeholder3;
            }

        }
    }
}
