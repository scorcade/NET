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

namespace _019_
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

        private void btn_Get_Click(object sender, RoutedEventArgs e)
        {



            try
            {
                
                //char chr = txt_chr.Text[0];//获得一个汉字字符
                char chr = txt_chr.Text[0];
                byte[] gb2312_bt =                                   
                Encoding.GetEncoding("utf-8").GetBytes(new char[] { chr });
                //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
               // Encoding.GetEncoding("gb2312").GetBytes(new char[] { chr });

                //Console.WriteLine(gb2312_bt);
                int n = (int)gb2312_bt[0] << 8;//将字节序列的第一个字节向左移8位
                n += (int)gb2312_bt[1];//第一个字节移8位后与第二个字节相加得到汉字编码
                txt_Num.Text = n.ToString();//显示汉字编码
            }
            catch (Exception)
            {
                MessageBox.Show(//异常提示信息
                    "请输入汉字字符！", "出现错误！");
            }



            //try
            //{
            //    char chr = txt_chr.Text[0];
            //    byte[] gb2312_bt = Encoding.GetEncoding("gb2312").GetBytes(new char[] { chr });
            //    int n = (int)gb2312_bt[0] << 8;
            //    n += (int)gb2312_bt[1];
            //    txt_Num.Text = n.ToString();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show(" Error! Please enter Chinese characters!");
            //}



        }
    }
}
