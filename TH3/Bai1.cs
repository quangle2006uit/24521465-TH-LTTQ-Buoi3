using System.Windows.Forms;

namespace TH3
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            System.Diagnostics.Debug.WriteLine("Constructor: Form1 được khởi tạo");
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine("Tạo và cấu hình các control, layout, thuộc tính.");

            this.Load += Bai1_Load;
            this.Shown += Bai1_Shown;
            this.Activated += Bai1_Activated;
            this.Deactivate += Bai1_Deactivate;
            this.FormClosing += Bai1_FormClosing;
            this.FormClosed += Bai1_FormClosed;
        }
        private void Bai1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form_Load: Chuẩn bị dữ liệu trước khi hiển thị form");
        }

        private void Bai1_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form_Shown: Form đã hiển thị lần đầu");
        }
        private void Bai1_Activated(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Form được focus ");
        }
        private void Bai1_Deactivate(object sender, EventArgs e) 
        {
            System.Diagnostics.Debug.WriteLine("Form Mất focus ");
        }
        private void Bai1_FormClosing(object sender, FormClosingEventArgs e) 
        {
            System.Diagnostics.Debug.WriteLine("Form đóng nhưng có thể huỷ đóng");
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("xác nhận đóng form", "Xác Nhận", buttons, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
               e.Cancel = false;
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void Bai1_FormClosed(object sender, EventArgs e) 
        {
            MessageBox.Show("form đóng hoàn toàn");
        }
    }
}
