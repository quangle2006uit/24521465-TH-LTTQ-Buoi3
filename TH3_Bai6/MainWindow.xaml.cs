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
using System.Windows.Shell;

namespace TH3_Bai6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string BoNho = "";
        string BoNhoTam = "0";
        string toantu = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Input(object sender, RoutedEventArgs e)
        {
            if (sender is Button bnt)
            {
                string Tam = Text_Box.Text;
                Tam += (bnt.Content).ToString();
                Text_Box.Text = Tam;
            }
        }
        private void BienDoi(object sender, RoutedEventArgs e)
        {
            if (sender is Button bnt)
            {
                string Tam = bnt.Content.ToString();
                string text = Text_Box.Text;
                double so;
                if (!double.TryParse(text, out so))
                {
                    MessageBox.Show("Số KHông Hợp Lệ !");
                    return;
                }
                if (Tam == "+/-")
                    so = -so;
                else if (Tam == "sqrt")
                    so = Math.Sqrt(so);
                else if (Tam == "%")
                    so = so / 100;
                else
                {
                    if (so == 0)
                    {
                        MessageBox.Show("KHông có 1/0!");
                        return;
                    }
                    so = 1 / so;
                }
                Text_Box.Text = so.ToString();
            }
        }
        private void ToanTu(object sender, RoutedEventArgs e)
        {
            if (sender is Button bnt)
            {
                string tt = bnt.Content.ToString();
                if (BoNho == "" )
                {
                    if (tt == "=")
                        return;
                    BoNho = Text_Box.Text.ToString();
                    toantu = tt;
                    Text_Box.Text = "";

                }
                else 
                {
                    if (Text_Box.Text != "")
                    {
                        double tam = Convert.ToDouble(BoNho);
                        if (toantu == "+")
                        {
                            tam += Convert.ToDouble(Text_Box.Text);
                        }
                        else if (toantu == "-")
                        {
                            tam -= Convert.ToDouble(Text_Box.Text);
                        }
                        else if (toantu == "X")
                        {
                            tam = tam * Convert.ToDouble(Text_Box.Text);
                        }
                        else if (toantu == "/")
                        {
                            if (Convert.ToDouble(Text_Box.Text) == 0)
                            {
                                MessageBox.Show("Không có phép chia cho 0");
                                Text_Box.Text = "";
                            }
                            else
                                tam /= Convert.ToDouble(Text_Box.Text);
                        }
                        Text_Box.Text = tam.ToString();
                    }
                    else
                        Text_Box.Text = "";
                        BoNho = "";

                }
            }
        }
        private void XoaBoNho(object sender, EventArgs e)
        {
            if (sender is Button bnt)
            {
                if (Text_Box.Text != "")
                {
                    string Text = bnt.Content.ToString();
                    if (Text == "C")
                    {
                        BoNho = "";
                        toantu = "";
                        Text_Box.Text = "";
                    }
                    else if (Text == "CE")
                    {
                        Text_Box.Text = "";
                    }
                    else
                    {
                        Text_Box.Text = Text_Box.Text.Substring(0, Text_Box.Text.Length - 1);
                    }
                }
            }
        }
        private void BONHOTAM(object sender, EventArgs e) {
            if (sender is Button bnt) {
              string Text = bnt.Content.ToString();
                if(Text == "MS")
                {
                    BoNhoTam =Text_Box.Text.ToString();
                    Text_Box.Text = "";
                }
                else if(Text == "MR")
                {
                    Text_Box.Text = BoNhoTam;
                }
                else if(Text == "M+")
                {
                    if(BoNhoTam ==""&& Text_Box.Text != "")
                    {
                       BoNhoTam=Text_Box.Text;

                    }
                    else if(BoNhoTam != "" && Text_Box.Text != "")
                    {
                        double tam = Convert.ToDouble(BoNhoTam);
                        tam += Convert.ToDouble(Text_Box.Text);
                        Text_Box.Text = tam.ToString();
                    }
                }
                else
                {
                    BoNhoTam = "";
                }
            }
        }
    }
}