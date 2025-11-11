using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH3
{
    public partial class Bai3 : Form
    {
        Random random = new Random();
        Button DoiMau = new Button();
        public Bai3()
        {
            InitializeComponent();
            DoiMau.Text = "Đổi Màu";
            DoiMau.Height = 100;
            DoiMau.Width = 300;
            DoiMau.BackColor = Color.White;
            DoiMau.ForeColor = Color.Red;
            DoiMau.TextAlign = ContentAlignment.MiddleCenter;
            DoiMau.Location = new Point(
    (this.ClientSize.Width - DoiMau.Width) / 2,
    (this.ClientSize.Height - DoiMau.Height) / 2
);
            this.Resize +=  CanGiuaButton;
            DoiMau.Click += DoiMauNen;
            this.Controls.Add(DoiMau);
        }
        private void DoiMauNen (object sender, EventArgs e)
        {
            int r = random.Next(256);
            int g = random.Next(256);
            int b = random.Next(256);
            this.BackColor=Color.FromArgb(r, g, b);
        }
        private void CanGiuaButton(object sender, EventArgs e)
        {
            DoiMau.Location = new Point(
                (this.ClientSize.Width - DoiMau.Width) / 2,
                (this.ClientSize.Height - DoiMau.Height) / 2
            );
        }
    }
}
