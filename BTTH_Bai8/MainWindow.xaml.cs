using System.Collections.ObjectModel;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BTTH_Bai8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class TaiKhoan
    {
        public decimal SoTaiKhoan { set; get; }
        public string Ten { set; get; }
        public string DiaChi { set; get; }
        public decimal SoTien { set; get; }
    }
    public partial class MainWindow : Window
    {
        public ObservableCollection<TaiKhoan> TaiKhoanList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            TaiKhoanList = new ObservableCollection<TaiKhoan>();
            DataContext = this;
        }

        private void Nhap(object sender, RoutedEventArgs e)
        {
            TaiKhoan tam = new TaiKhoan();
            decimal stk;
            if (!decimal.TryParse(STK.Text.ToString(), out stk))
            {
                MessageBox.Show("Số Tài Khoản Không Hợp Lệ !");
                return;
            }
            else tam.SoTaiKhoan = stk;
            if (string.IsNullOrEmpty(TKH.Text.ToString()))
            {
                MessageBox.Show("Tên Khách Hàng Không Hợp Lệ !");
                return;
            }
            else
                tam.Ten = TKH.Text.ToString();
            if (string.IsNullOrEmpty(DC.Text.ToString()))
            {
                MessageBox.Show("Địa Chỉ Khách Hàng Không Hợp Lệ !");
                return;
            }
            else
                tam.DiaChi = DC.Text.ToString();
            decimal st;
            if (!decimal.TryParse(ST.Text.ToString(), out st))
            {
                MessageBox.Show("Số Tiền Không Hợp Lệ !");
                return;
            }
            else tam.SoTien = st;
                bool kt = true;
            TaiKhoan tam1 = new TaiKhoan();
            bool kt1 = false;
            foreach (TaiKhoan tk in TaiKhoanList)
            {
                if (tk.SoTaiKhoan == tam.SoTaiKhoan)
                {
                    if (tk.Ten == tam.Ten && tk.DiaChi == tam.DiaChi)
                    {
                        tam1 = tk;
                        tam.SoTien = tk.SoTien + tam.SoTien;
                        kt1 = true;
                    }
                    else
                    {
                        MessageBox.Show("Số Tài khản đã tồn tại (Tên hoặc địa chỉ không giống)");
                        return;
                    }
                    kt = false;
                }
            }
            if (kt1)
            {
                TaiKhoanList.Remove(tam1);
                TaiKhoanList.Add(tam);
                MessageBox.Show("Cập Nhập dữ liệu thành công!");
            }
            if (kt)
            {

                TaiKhoanList.Add(tam);
                MessageBox.Show("Thêm dữ liệu Thành công!");
            }
        }
        private void Xoa(object sender, RoutedEventArgs e)
        {
            TaiKhoan tam = new TaiKhoan();
            decimal stk;
            if (!decimal.TryParse(STK.Text.ToString(), out stk))
            {
                MessageBox.Show("Số Tài Khoản Không Hợp Lệ !");
                return;
            }
            else tam.SoTaiKhoan = stk;
            if (string.IsNullOrEmpty(TKH.Text.ToString()))
            {
                MessageBox.Show("Tên Khách Hàng Không Hợp Lệ !");
                return;
            }
            else
                tam.Ten = TKH.Text.ToString();
            if (string.IsNullOrEmpty(DC.Text.ToString()))
            {
                MessageBox.Show("Địa Chỉ Khách Hàng Không Hợp Lệ !");
                return;
            }
            else
                tam.DiaChi = DC.Text.ToString();
            decimal st;
            if (!decimal.TryParse(ST.Text.ToString(), out st))
            {
                MessageBox.Show("Số Tiền Không Hợp Lệ !");
                return;
            }
            else tam.SoTien = st;
            TaiKhoan taiKhoanCanXoa = null;

            foreach (TaiKhoan tk in TaiKhoanList)
            {
                if (tk.SoTaiKhoan == tam.SoTaiKhoan && tk.Ten == tam.Ten && tk.DiaChi == tam.DiaChi && tam.SoTien == tk.SoTien)
                {
                    taiKhoanCanXoa = tk; 
                    break; 
                }
            }
            if (taiKhoanCanXoa != null)
            {
                TaiKhoanList.Remove(taiKhoanCanXoa);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản để xóa.");
            }
        }
        private void lvTaiKhoan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = sender as ListView;
            TaiKhoan tk = lv.SelectedItem as TaiKhoan;
            if (tk != null)
            {
                // 4. Giờ bạn đã có đối tượng, hãy điền dữ liệu vào TextBox
                //    (Giả sử bạn có các TextBox tên là STK, TKH, DC, ST)

                STK.Text = tk.SoTaiKhoan.ToString();
                TKH.Text = tk.Ten;
                DC.Text = tk.DiaChi;
                ST.Text = tk.SoTien.ToString();
            }
        }
        private void Thoat(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}