using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoustavaFormApp
{
    public  class Vykresly
    {

        public Graphics Graphics { get; set; }

        public Color BackgroundColor { get; set; }

        public Color ForegroundColor { get; set; }

        

        public  void kruh(Graphics g, Pen pen, int x, int y, int size)
        {
            g.DrawEllipse(pen, x, y, size, size);
            
        }


    }
}
