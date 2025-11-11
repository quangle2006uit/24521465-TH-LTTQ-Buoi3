using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TH3
{
    public partial class Bai2 : Form
    {
        Random random = new Random();
        Graphics g;
        public Bai2()
        {
            InitializeComponent();
            g=CreateGraphics();
            this.Click += LamMoi;
        }
        private void LamMoi(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            int x = random.Next(this.ClientSize.Width - 100);
            int y = random.Next(this.ClientSize.Height - 30);

            g.DrawString("Paint Event", new Font("Arial", 20), Brushes.Black, x, y);
        }
    }
}