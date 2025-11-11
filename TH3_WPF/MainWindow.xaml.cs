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

namespace TH3_WPF
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


        private void Tinh_Toan(object sender, RoutedEventArgs e)
        {
            if (sender is Button bnt) 
            {
                double so1, so2;

                if (!double.TryParse(Num1.Text, out so1))
                {
                    MessageBox.Show("Giá trị nhập ở Number 1 không hợp lệ. Vui lòng nhập số!");
                    return;
                }
                if (!double.TryParse(Num2.Text, out so2))
                {
                    MessageBox.Show("Giá trị nhập ở Number 2 không hợp lệ. Vui lòng nhập số!");
                    return;
                }
                so1 = Convert.ToDouble(Num1.Text);
                so2 = Convert.ToDouble(Num2.Text);
                string phepToan = bnt.Content.ToString();
                if (phepToan == "+")
                {
                    Answer.Text = Convert.ToString(so1+so2);
                }
                else if (phepToan == "-")
                    Answer.Text = Convert.ToString(so1 - so2);
                else if(phepToan == "*")
                    Answer.Text = Convert.ToString(so1 * so2);
                else if (phepToan == "/")
                {
                    if (so2 == 0)
                    {
                        MessageBox.Show("Không thực hiện được Phép chia vì Number 2 bằng 0!");
                        return;
                    }
                    Answer.Text = Convert.ToString(so1 / so2);
                }
            }
        }
    }
}