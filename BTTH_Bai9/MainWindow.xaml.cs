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

namespace BTTH_Bai9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class SinhVien
    {
        public string? MaSinhVien {  get; set; }
        public string? HoTen {  get; set; }
        public string? ChuyenNganh {  get; set; }
        public string? GioiTinh { get; set; }
        public string? MonHoc {  get; set; }

    }
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> MonHoc { get; set; }
        public ObservableCollection<string> MonHocDaChon { get; set; }
        public ObservableCollection<string> KHMT { get; set; }
        public ObservableCollection<string> KTPM { get; set; }
        public ObservableCollection<string> HTTT { get; set; }
        public ObservableCollection<string> KTMT { get; set; }
        public ObservableCollection<SinhVien> SINHVIEN { get; set; }
        private int Index;
        private int IndexXoa;
        private string TenNganh;

        public MainWindow()
        {
            InitializeComponent();
            Index = -1;
            IndexXoa = -1;
            TenNganh = "";
            SINHVIEN = new ObservableCollection<SinhVien>();
            KHMT = new ObservableCollection<string>
    {
        "Cấu Trúc Dữ Liệu & Giải Thuật",
        "Hệ Điều Hành",
        "Trí Tuệ Nhân Tạo",
        "Lý Thuyết Đồ Thị"
    };

            KTPM = new ObservableCollection<string>
    {
        "Quy Trình Phát Triển Phần Mềm",
        "Kiểm Thử Phần Mềm (Testing)",
        "Mẫu Thiết Kế (Design Patterns)",
        "Quản Lý Dự Án Phần Mềm"
    };

            HTTT = new ObservableCollection<string>
    {
        "Cơ Sở Dữ Liệu Nâng Cao",
        "Phân Tích Thiết Kế HTTT",
        "Khai Phá Dữ Liệu (Data Mining)",
        "Quản Trị Hệ Thống Thông Tin"
    };

            KTMT = new ObservableCollection<string>
    {
        "Kiến Trúc Máy Tính",
        "Vi Xử Lý & Vi Điều Khiển",
        "Thiết Kế Hệ Thống Nhúng",
        "Mạng Máy Tính Nâng Cao"
    };
            MonHoc = new ObservableCollection<string>();
            MonHocDaChon = new ObservableCollection<string>();
            this.DataContext = this;
        }

        private void SLC(object sender, SelectionChangedEventArgs e)
        {
            MonHoc.Clear();
            MonHocDaChon.Clear();
            ComboBox cb = sender as ComboBox;
             ObservableCollection<string> tam;
            tam = new ObservableCollection<string>();
            if (cb.SelectedIndex == 0)
            {
                tam = KTPM;
                TenNganh = "Kỹ Thuật Phần Mềm";
            }
            else if (cb.SelectedIndex == 1)
            {
                tam = KHMT;
                TenNganh = "Khoa Học Máy Tính";
            }
            else if (cb.SelectedIndex == 2)
            {
                tam = HTTT;
                TenNganh = "Hệ Thống Thông Tin";
            }
            else if (cb.SelectedIndex == 3)
            {
                tam = KTMT;
                TenNganh = "Kỹ Thuật Máy Tính";
            }
            foreach (string s in tam) {
              MonHoc.Add(s);
            }
        }

        private void Them(object sender, RoutedEventArgs e)
        {
            if(Index!=-1)
            MonHocDaChon.Add(MonHoc[Index]);
        }
        private void Xoa(object sender, RoutedEventArgs e)
        {
            if(IndexXoa!=-1)
                MonHocDaChon.Remove(MonHocDaChon[IndexXoa]);
        }

        private void SLC_ListBox(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            Index = listBox.SelectedIndex;
        }
        private void SLC_ListBox_DaChon(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            IndexXoa = listBox.SelectedIndex;
        }

        private void Luu(object sender, RoutedEventArgs e)
        {
            if (MaSV.Text == "" || HT.Text == "" || LVDC.SelectedIndex == -1 || MonHocDaChon.Count == 0)
            {
                MessageBox.Show("Vui Lòng Thêm Đầy đủ Thông Tin!");
                return;
            }
            foreach(string s in MonHocDaChon)
            {
                SinhVien tam = new SinhVien();
                if (Nam.IsChecked == true)
                    tam.GioiTinh = "Nam";
                else tam.GioiTinh = "Nữ";
                tam.MaSinhVien = MaSV.Text;
                tam.HoTen = HT.Text;
                tam.ChuyenNganh = TenNganh;
                tam.MonHoc = s;
                SINHVIEN.Add(tam);
            }
        }
        private void XoaChon(object sender, RoutedEventArgs e)
        {
            MonHocDaChon.Clear();
        }
    }
}