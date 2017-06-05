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
        public MainWindow()
        {
            InitializeComponent();
            kontrola = 0;
        }

        public int kontrola;
        

        private void button1_Click(object sender, EventArgs e)
        {
            //dát do konstant graphic pen solidbrush
            Vykresly vykresy = new Vykresly();
            Graphics g = base.CreateGraphics();
            Pen myPen = new Pen(Color.Red);

            vykresy.kruh(g, Constants.slunceTloustkaCary, Constants.poziceSlunceX, Constants.poziceSlunceY, Constants.velikostSlunce);

            //vykresy.kruh(g, Constants.Planeta1TloustkaCary, Constants.pozicePlaneta1X, Constants.pozicePlaneta1Y, Constants.velikostPlaneta1);

            //vykresy.kruh(g, Constants.Planeta1TloustkaCary, Constants.pozicePlaneta2X, Constants.pozicePlaneta2Y, Constants.velikostPlaneta2);

            timer1.Enabled = true;
            //rychlost obehu
         timer1.Interval = 50;


        }
        public void vykreslyPlanetu(bool isZobrazit)
        {
            Vykresly vykresy = new Vykresly();
            Graphics g = base.CreateGraphics();
            if (isZobrazit)
            {
                if (kontrola % 2 == 0)
                {
                    Pen myPen = new Pen(Color.Red);
                    vykresy.kruh(g, Constants.Planeta1Barva, Constants.pozicePlaneta1X, Constants.pozicePlaneta1Y, Constants.velikostPlaneta1);
                }

                vykresy.kruh(g, Constants.RaketaBarva, Constants.poziceRaketaX, Constants.poziceRaketaY, Constants.velikostRaketa);

            }
            else
            {
                
                    Pen barvaPozadi = new Pen(this.BackColor);
                    vykresy.kruh(g, barvaPozadi, Constants.pozicePlaneta1X, Constants.pozicePlaneta1Y, Constants.velikostPlaneta1);
                
            }
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            kontrola++;
            double presnost = 0.1;
            //schovám planetu na staré pozici
            vykreslyPlanetu(false);
            //přepočítám pozice planety
            double x = Math.Cos(presnost) * (Constants.pozicePlaneta1X - Constants.poziceSlunceX) - Math.Sin(presnost) * (Constants.pozicePlaneta1Y - Constants.poziceSlunceY) + Constants.poziceSlunceX;
            double y = Math.Sin(presnost) * (Constants.pozicePlaneta1X - Constants.poziceSlunceX) + Math.Cos(presnost) * (Constants.pozicePlaneta1Y - Constants.poziceSlunceY) + Constants.poziceSlunceY;
            Constants.pozicePlaneta1X = Convert.ToInt32(x);
            Constants.pozicePlaneta1Y = Convert.ToInt32(y);




            //zobrazím planetu na nové pozici
            vykreslyPlanetu(true);
            
           


        }

        
    }
}
