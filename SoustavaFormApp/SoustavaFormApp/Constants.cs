using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoustavaFormApp
{
    public static class Constants 
    {
        public static decimal RychlostSvetla = 365888;

        //Slunce
        public static int poziceSlunceX = 350;
        public static int poziceSlunceY = 175;
        public static int velikostSlunce = 50;

      


        public static Pen slunceTloustkaCary = new Pen(Color.Red);

        //Planeta1
        public static int pozicePlaneta1X = 300;
        public static int pozicePlaneta1Y = 100;
        public static int velikostPlaneta1 = 20;

       
        public static Pen Planeta1Barva = new Pen(Color.Blue);

        //Planeta2
        public static int pozicePlaneta2X = 350;
        public static int pozicePlaneta2Y = 350;
        public static int velikostPlaneta2 = 25;

        public static Pen Planeta2TloustkaCary = new Pen(Color.Green);
        //Raketa
        public static int poziceRaketaX = 350;
        public static int poziceRaketaY = 350;
        public static int velikostRaketa = 25;

        public static Pen RaketaBarva = new Pen(Color.Green);



        

    }
}
