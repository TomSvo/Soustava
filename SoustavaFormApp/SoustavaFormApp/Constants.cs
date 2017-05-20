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
        public static int poziceSlunceX = 200;
        public static int poziceSlunceY = 200;
        public static int velikostSlunce = 50;

        public static Pen slunceTloustkaCary = new Pen(Color.Red);

        //Planeta1
        public static int pozicePlaneta1X = 300;
        public static int pozicePlaneta1Y = 300;
        public static int velikostPlaneta1 = 20;

        public static Pen Planeta1TloustkaCary = new Pen(Color.Blue);

        //Planeta2
        public static int pozicePlaneta2X = 350;
        public static int pozicePlaneta2Y = 350;
        public static int velikostPlaneta2 = 25;

        public static Pen Planeta2TloustkaCary = new Pen(Color.Green);


    }
}
