using System.Drawing;
using System.Windows.Forms;
using colectii_generice;
using colectii_generice.colectii;
using colectii_generice.controllers;

namespace parcAuto
{
    public class ViewPersoana : Panel
    {
        private Label lblPers;

        private Panel pnlContainer;

        public ViewPersoana(Control par, Persoana pers, Controller control)
        {
            this.Parent = par;
            this.Size = par.Size;
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 0);

            lblPers = new Label
            {
                Parent = this,
                AutoSize = false,
                Location = new Point(0, 0),
                Text = pers.ToString(),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Size = new Size(349, 149)
            };

            pnlContainer = new Panel
            {
                Parent = this,
                Location = new Point(0, 152),
                Size = new Size(1288, 620),
                AutoScroll = true
            };

            populateCars(control, pers.Id);
        }

        private void populateCars(Controller control, int id)
        {
            Lista<Masina> list = control.getMasiniPers(id);

            int y = 0;  

            for (int i = 0; i < list.size(); i++)
            {
                Label lblCar = new Label
                {
                    Parent = pnlContainer,
                    AutoSize = false,
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                    Location = new Point(511, y),
                    Size = new Size(241, 127),
                    Text = list.get(i).ToString()
                };

                y += 150;
            }
        }



    }
}