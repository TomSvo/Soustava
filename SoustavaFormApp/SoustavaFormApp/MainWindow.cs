using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoustavaFormApp
{
    public partial class MainWindow : Form
    {

        private Game hra;
        public MainWindow()
        {
            InitializeComponent();
            this.hra = new Game(this);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            hra.Update();
        }

        private void Platno_Paint(object sender, PaintEventArgs e)
        {
            hra.Kresli(e.Graphics);
        }

        public PictureBox VratPlatno()
        {
            return this.Platno;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            if (key == Keys.A)
            {
                this.hra.OtocRaketu(-8f);
            }
            if (key == Keys.D)
            {
                this.hra.OtocRaketu(8f);
            }
            if (key == Keys.W)
            {
                this.hra.Raketa.Zazeh();
            }
        }
    }
}
