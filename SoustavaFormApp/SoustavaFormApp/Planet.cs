using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoustavaFormApp
{
    public class Planet
    {
        public double Velikost { get; set; }

        public double RychlostX { get; set; }
        public double RychlostY { get; set; }

        public double PositionX { get; set; }

        public double PositionY { get; set; }

        public double Hmotnost { get; set; }

        public SolidBrush Stetec { get; set; }

        public Planet(double velikost, double rychlostX, double rychlostY, double positionX, double positionY, double hmotnost,SolidBrush stetec)
        {
            this.Stetec = stetec;
            this.Velikost = velikost;
            this.Hmotnost = hmotnost;
            this.RychlostX = rychlostX;
            this.RychlostY = rychlostY;
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public virtual void Kresli(Graphics gr)
        {
            gr.TranslateTransform((float)(this.PositionX), (float)this.PositionY);
            gr.FillEllipse(this.Stetec, (float)this.Velikost / 2, (float)-this.Velikost / 2, (float)this.Velikost, (float)this.Velikost);
            gr.ResetTransform();
        }
    }
}
