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
        public static int velikostSlunce = 300;

        public static Pen slunceTloustkaCary = new Pen(Color.Red);
        //a takhle i s ostatnima. priste uz to jenom rozpohybujem, planetu vytvoris uplne stejne jako slunce ok commitni to jj
    }
}
