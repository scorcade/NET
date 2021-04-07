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

namespace WpfApp2
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Background = Brushes.Red;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
           
               
            
            
            
            // MessageBox.Show( checkBox.IsChecked.ToString());        ---------------------

        //    string strContens = "";        -----------------------
        //    foreach ( UIElement ele in grid1.Children )   -
        //    {
        //        if (ele is CheckBox)
        //        {
        //            CheckBox chk = ele as CheckBox;
        //            if (chk.IsChecked==true)
        //            {
        //                if (strContens!="")
        //                {
        //                    strContens += ",";
        //                }
        //                strContens += chk.Content.ToString();
        //            }
        //        } 
        //    }
        //    MessageBox.Show(strContens);
        //}



        //private void button_Click(object sender, RoutedEventArgs e) => (sender as Button).Background = Brushes.Red;
        //private void button1_Click(object sender, RoutedEventArgs e) => (sender as Button).Background = Brushes.Red;


    }
}
