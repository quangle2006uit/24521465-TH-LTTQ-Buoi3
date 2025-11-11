using System.Net.NetworkInformation;
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

namespace BTTH_Bai7
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
        int TongTien = 0;
        private void SoGhe(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn) {
               if(btn.Background == Brushes.White)
                {
                    btn.Background = Brushes.Blue;
                }
               else if(btn.Background == Brushes.Blue)
                {
                    btn.Background = Brushes.White;
                }
               else if(btn.Background == Brushes.Yellow)
                {
                    MessageBox.Show($"Ghế {btn.Content} đã được chọn rồi");
                }
            }
        }

        private void Chon(object sender, RoutedEventArgs e)
        {
            foreach (Button btn in Ghe.Children) { 
               if(btn.Background == Brushes.Blue)
                {
                    if (btn.Content.ToString() == "1" || btn.Content.ToString() == "2" || btn.Content.ToString() == "3" || btn.Content.ToString() == "4" || btn.Content.ToString() == "5")
                        TongTien += 5000;
                    else if (btn.Content.ToString() == "6" || btn.Content.ToString() == "7" || btn.Content.ToString() == "8" || btn.Content.ToString() == "9" || btn.Content.ToString() == "10")
                        TongTien += 6500;
                    else
                        TongTien += 8000;
                    btn.Background = Brushes.Yellow;
                }
            }
            TT.Text = TongTien.ToString();
            TongTien = 0;
        }

        private void HuyBo(object sender, RoutedEventArgs e)
        {
            foreach (Button btn in Ghe.Children)
            {
                if (btn.Background == Brushes.Blue)
                {
                    
                    btn.Background = Brushes.White;
                }
            }
        }

        private void KetThuc(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}