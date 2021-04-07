using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfApp8.NewFolder1;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RichTextBox richTextBox1 = new RichTextBox();
            richTextBox1.tex
        }

        private void richTextBox1_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);                   //在控件LinkClicked事件中编写如下代码实现内容中的网址单击后可以访问网址



        }
    }
