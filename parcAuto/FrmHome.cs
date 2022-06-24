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
using colectii_generice.controllers;

namespace parcAuto
{
    public partial class FrmHome : Form
    {
        private PnlHome pnlHome;
        private PnlModels pnlModels;
        private Controller control;
        public FrmHome()
        {
            InitializeComponent();

            this.Size = new Size(1303, 811);

            pnlHome = new PnlHome(this);
            pnlModels = new PnlModels(this);
            control = new Controller();

            pnlHome.Show();
            pnlModels.Hide();

            pnlHome.btnClick += btn_Click;
            pnlModels.backClick += lblBack_Click;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text.Equals("Persoane"))
            {
                pnlModels.populatePers(control);
            }
            else
            {
                pnlModels.populateMasini(control.getMasini());
            }

            pnlModels.Show();
            pnlHome.Hide();
            
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            pnlModels.Hide();
            pnlHome.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
