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
using System.Windows.Threading;


namespace clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timers = new DispatcherTimer();
            timers.Interval = TimeSpan.FromSeconds(1);
            timers.Tick += Timers_Tick;
            timers.Start();
        }

        private void Timers_Tick(object sender, EventArgs e)
        {
            textBox.Text = DateTime.Now.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = DateTime.Now.ToString();
            
        }
    }
}
