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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            MenuStrip menu = new MenuStrip();
            ToolStripMenuItem Fomat = new ToolStripMenuItem("FOMAT");
            ToolStripMenuItem Color = new ToolStripMenuItem("COLOR");
            Color.Click += DOIMAU;
            Fomat.DropDownItems.Add(Color);
            menu.Items.Add(Fomat);
            this.Controls.Add(menu);
            this.MainMenuStrip = menu;
        }
        private void DOIMAU(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }
    }
}
