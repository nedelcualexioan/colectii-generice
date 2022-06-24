using System;
using System.Drawing;
using System.Windows.Forms;
using colectii_generice;
using colectii_generice.colectii;
using colectii_generice.controllers;

namespace parcAuto
{
    public class PnlModels : Panel
    {
        private Label lblBack;
        private Panel pnlContainer;

        public event EventHandler backClick;
        public PnlModels(Control par)
        {
            this.Parent = par;
            this.Location = new Point(0, 0);
            this.Size = par.Size;
            this.BackColor = Color.WhiteSmoke;
            this.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            pnlContainer = new Panel
            {
                Parent = this,
                AutoScroll = true,
                Size = new Size(this.Width, this.Height - 83),
                Location = new Point(0, 83),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            lblBack = new Label
            {
                Parent = this,
                AutoSize = true,
                Location = new Point(12, 9),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Text = "<= Back",
                Cursor = Cursors.Hand
            };
            lblBack.Click += lblBack_Click;


        }

        public void populatePers(Controller control)
        {
            pnlContainer.Controls.Clear();

            int y = 60;

            for (int i = 0; i < control.getPersoane().size(); i++)
            {
                Persoana pers = control.getPersoane().get(i);

                Label lblPers = new Label
                {
                    Parent = pnlContainer,
                    AutoSize = false,
                    Size = new Size(352, 25),
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                    Location = new Point(60, y),
                    Text = "=> " + pers.Nume + " " + pers.Prenume,
                    Cursor = Cursors.Hand
                };

                lblPers.Click += (s, e) => lblPers_Click(s, e, pers, control);

                y += 25;
            }
        }

        public void populateMasini(Lista<Masina> list)
        {
            pnlContainer.Controls.Clear();

            int y = 60;

            for (int i = 0; i < list.size(); i++)
            {
                String txt = list.get(i).ToString();

                Label lblCar = new Label
                {
                    Parent = pnlContainer,
                    AutoSize = false,
                    Size = new Size(352, 25),
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                    Location = new Point(60, y),
                    Text = "=> " + list.get(i).Marca + " " + list.get(i).Model,
                    Cursor = Cursors.Hand
                };
                lblCar.Click += (s, e) => lblCar_Click(s, e, txt);
                

                y += 25;
            }
        }

        private void lblCar_Click(object sender, EventArgs e, String descriere)
        {
            MessageBox.Show(descriere, "Masina", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            if (backClick != null)
            {
                backClick(this, null);
            }
        }

        private void lblPers_Click(object sender, EventArgs e, Persoana pers, Controller ctr)
        {
            ViewPersoana pnlPers = new ViewPersoana(this.Parent, pers, ctr);

            pnlPers.Show();
            this.Hide();
        }

    }
}