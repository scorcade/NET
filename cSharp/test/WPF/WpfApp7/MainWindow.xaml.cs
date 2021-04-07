using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            System.Windows.Forms.Integration.WindowsFormsHost host =
                new System.Windows.Forms.Integration.WindowsFormsHost();

            System.Windows.Forms.WebBrowser webBrowser = new System.Windows.Forms.WebBrowser();

            webBrowser.Url = new Uri("http://www.baidu.com");

            host.Child = webBrowser;

            this.grid.Children.Add(host);



            //// private view sourceprint?private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
            ////{
            ////    e.Cancel = true;
            // //}

        }
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //将所有的链接的目标，指向本窗体  
            foreach (HtmlElement archor in this.webBrowser.Document.Links)
            {
                archor.SetAttribute("target", "_self");
            }


            //将所有的FORM的提交目标，指向本窗体  
            foreach (HtmlElement form in this.webBrowser.Document.Forms)
            {
                form.SetAttribute("target", "_self");
            }

        }

    }

    
}
