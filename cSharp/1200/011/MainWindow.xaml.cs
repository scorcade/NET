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

namespace _011
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

        private List<double> G_list_value = new List<double>();
        private bool addPlusSign = false; //Determine if the + sign was just pressed 
        private bool ectEqualSign = false;//Determine if the = sign was just pressed
        private bool addContinuous = false;  //Prevent continuous pressing of +

        void GetValue()
        {
            double P_db1_temp = 0;
            foreach (double item in G_list_value)
            {
                P_db1_temp += item;
            }
            textBox.Text = P_db1_temp.ToString();
        }
        string GetString()
        {
            string P_str_temp = string.Empty;
            for (int i = 0; i < G_list_value.Count; i++)
            {
                if (i != 0)
                {
                    P_str_temp += "+" + G_list_value[i].ToString();
                }
                else
                {
                    P_str_temp = G_list_value[i].ToString();
                }
            }
            return P_str_temp;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            G_list_value.Clear();
            according.Content = GetString();
            textBox.Clear();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (ectEqualSign)
            {
                ectEqualSign = false;
                addContinuous = true;
            }
            else 
            {
                if (!addContinuous)
                {
                    G_list_value.Add(double.Parse(textBox.Text));
                    GetValue();
                    according.Content = GetString();
                    addPlusSign = true;
                    addContinuous = true;

                }
            }
        }

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            if (!addContinuous)
            {
                if (!ectEqualSign)
                {
                    G_list_value.Add(double.Parse(textBox.Text));
                    GetValue();
                    according.Content = GetString();
                    addPlusSign = true;
                    addContinuous = true;
                }
            }
        }

        private void digitNum0_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "0";
                addContinuous = false;
            }
        }

        private void digitNum1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "1";
                addContinuous = false;
            }
        }

        private void digitNum2_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "2";
                addContinuous = false;
            }
        }

        private void digitNum3_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "3";
                addContinuous = false;
            }
        }

        private void digitNum4_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "4";
                addContinuous = false;
            }
        }

        private void digitNum5_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "5";
                addContinuous = false;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "6";
                addContinuous = false;
            }
        }

        private void digitNum7_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "7";
                addContinuous = false;
            }
        }

        private void digitNum8_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "8";
                addContinuous = false;
            }
        }

        private void digitNum9_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length < 9)
            {
                if (addPlusSign)
                {
                    textBox.Clear();
                    addPlusSign = false;
                }
                textBox.Text += "9";
                addContinuous = false;
            }
        }

      
    }
}
