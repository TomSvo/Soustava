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
        
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            //dát do konstant graphic pen solidbrush
            Vykresly vykresy = new Vykresly();
            Graphics g = base.CreateGraphics();
            Pen myPen = new Pen(Color.Red);
            SolidBrush mySolidBrush = new SolidBrush(Color.Red);

            vykresy.kruh(g, Constants.slunceTloustkaCary, Constants.poziceSlunceX, Constants.poziceSlunceY, Constants.velikostSlunce);

            vykresy.kruh(g, Constants.Planeta1TloustkaCary, Constants.pozicePlaneta1X, Constants.pozicePlaneta1Y, Constants.velikostPlaneta1);

            vykresy.kruh(g, Constants.Planeta1TloustkaCary, Constants.pozicePlaneta2X, Constants.pozicePlaneta2Y, Constants.velikostPlaneta2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
