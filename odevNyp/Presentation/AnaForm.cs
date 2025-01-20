using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevNyp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            kayanPanel.Height = anaSayfaBtn.Height;
            kayanPanel.Top = anaSayfaBtn.Top;
            anaSayfaCagır.BringToFront();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
