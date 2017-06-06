using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoustavaFormApp
{
    public class Raketa : Planet
        {

        public Image Obrazek { get; set; }
        public float Uhel { get; set; }
        public Raketa(double velikost, double rychlostX, double rychlostY, double positionX, double positionY,double hmotnost) : base(velikost, rychlostX, rychlostY, positionX, positionY,hmotnost,new SolidBrush(Color.Empty))
            {
            this.Obrazek = ZdrojovySoubor.Raketa;
            this.Uhel = 0f;
        }

        public override void Kresli(Graphics gr)
        {
            gr.TranslateTransform((float)(this.PositionX), (float)this.PositionY);
            gr.RotateTransform(this.Uhel);

            gr.DrawImage(this.Obrazek, (float)-this.Velikost / 2, (float)-this.Velikost / 2, (float)this.Velikost, (float)this.Velikost);

            gr.ResetTransform();
        }

        public void Zazeh()
        {
            this.RychlostX += Math.Sin(this.Uhel * (Math.PI / 180));
            this.RychlostY += -Math.Cos(this.Uhel * (Math.PI / 180));
        }

    }
    }
