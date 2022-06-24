using System;
using System.Drawing;
using System.Windows.Forms;

namespace parcAuto
{
    public class PnlHome : Panel
    {
        private Button btnPersons;
        private Button btnCars;

        public event EventHandler btnClick;

        public PnlHome(Control parent)
        {
            this.Size = parent.Size;
            this.Parent = parent;
            this.BackColor = Color.WhiteSmoke;
            this.Location = new Point(0, 0);

            btnCars = new Button
            {
                Parent = this,
                Size = new Size(128, 65),
                Location = new Point(630, 333),
                Text = "Masini",
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Cursor = Cursors.Hand
            };

            btnPersons = new Button
            {
                Parent = this,
                Size = new Size(128, 65),
                Location = new Point(496, 333),
                Text = "Persoane",
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Cursor = Cursors.Hand
            };

            btnCars.Click += btn_Click;
            btnPersons.Click += btn_Click;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (btnClick != null)
            {
                btnClick(sender, null);
            }
        }
    }
}