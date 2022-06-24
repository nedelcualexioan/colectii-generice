using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parc_auto
{
    public partial class FrmHome : Form
    {
        private PnlHome pnlHome;

        public FrmHome()
        {
            InitializeComponent();

            this.Size = new Size(1303, 811);

            pnlHome = new PnlHome(this);

            pnlHome.Show();

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
