using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int[] szamok = new int[10];
        static string[] muveletijelek = new string[9];
        static bool feladat = false;
        static string ertek;
        static int vegertek = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (feladat==true)
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "1";
            ertek +="1";

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if(feladat==true)
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "2";
            ertek +="2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if(feladat==true)
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "3";
            ertek +="3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if(feladat== true)
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "4";
            ertek +="4";  
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (feladat== true)
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "5";
            ertek +="5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (feladat==true) 
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "6";
            ertek +="6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (feladat==true)
            {
                lblkiiras.Content = "";
                feladat = false;
            }
            lblkiiras.Content+="7";
            ertek +="7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (feladat==true)
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "8";
            ertek +="8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (feladat == true)
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "9";
            ertek +="9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if(feladat==true)
            {
                lblkiiras.Content = "";
                feladat=false;
            }
            lblkiiras.Content += "0";
            ertek +="0";
        }

        private void btnosszeadas_Click(object sender, RoutedEventArgs e)
        {
           
            lblkiiras.Content += "+";
        }

        private void btnkivonas_Click(object sender, RoutedEventArgs e)
        {
            
            lblkiiras.Content+= "-";
        }
    }
}