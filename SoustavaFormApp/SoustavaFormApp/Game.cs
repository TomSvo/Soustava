using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoustavaFormApp
{
    public class Game
    {
        private double konstanta = 0.0001;
        public List<Planet> Planety { get; set; }
        public Raketa Raketa { get; set; }
        public MainWindow form { get; set; }

        public Game(MainWindow fm)
        {
            this.Planety = new List<Planet>();
            this.form = fm;

            this.Raketa = new Raketa(30, 0.2, 0, 300, 10, 1);
            this.Planety.Add(this.Raketa);
            this.Planety.Add(new Planet(60, 0, 0, 300, 300, 200000,new SolidBrush(Color.Red)));
            this.Planety.Add(new Planet(35, 0.25, 0, 300, 100, 100,new SolidBrush(Color.Blue)));
        }
        public void Update()
        {
            for (int i = 0; i < Planety.Count; i++)
            {
                for (int a = 0; a < Planety.Count; a++)
                {
                    this.Vypocti(this.Planety[i], this.Planety[a]);
                }
            }

            for (int i = 0; i < Planety.Count; i++)
            {
                bool zmena = false;
                for (int a = 0; a < Planety.Count; a++)
                {
                    zmena = this.Kolize(this.Planety[i], this.Planety[a]);
                    if (zmena)
                    {
                        break;
                    }
                }

                if (zmena)
                {
                    break;
                }
            }

            for (int i = 0; i < Planety.Count; i++)
            {
                this.Posun(this.Planety[i]);

            }

            this.form.VratPlatno().Invalidate();
        }
        public void Kresli(Graphics gr)
        {
            for (int i = 0; i < this.Planety.Count; i++)
            {
                this.Planety[i].Kresli(gr);
            }
        }
        private void Vypocti(Planet pl1,Planet pl2)
        {
            if (pl1 == pl2) return;

            double rozdilX = pl1.PositionX - pl2.PositionX;
            double rozdilY = pl1.PositionY - pl2.PositionY;

            double vzdalenost = Math.Sqrt((rozdilX * rozdilX) + (rozdilY * rozdilY));

            double sila = (this.konstanta * pl1.Hmotnost * pl2.Hmotnost) / (vzdalenost * vzdalenost);

            pl1.RychlostX -= sila * (rozdilX / vzdalenost) / pl1.Hmotnost;
            pl1.RychlostY -= sila * (rozdilY / vzdalenost) / pl1.Hmotnost;
        }

        private void Posun(Planet pl)
        {
            pl.PositionX += pl.RychlostX;
            pl.PositionY += pl.RychlostY;
        }

        public void OtocRaketu(float uhel)
        {
            this.Raketa.Uhel += uhel;
        }

        private bool Kolize(Planet pl1,Planet pl2)
        {
            if (pl1 == pl2) return false;

            double rozdilX = pl1.PositionX - pl2.PositionX;
            double rozdilY = pl1.PositionY - pl2.PositionY;

            double vzdalenost = Math.Sqrt((rozdilX * rozdilX) + (rozdilY * rozdilY));

            if ((pl1.Velikost /2 + pl2.Velikost/2) > vzdalenost)
            {
                if (pl1.Hmotnost > pl2.Hmotnost)
                {
                    pl1.Velikost += pl2.Velikost;
                    pl1.Hmotnost += pl2.Hmotnost;

                    this.Planety.Remove(pl2);
                }
                else
                {
                    pl2.Velikost += pl1.Velikost;
                    pl2.Hmotnost += pl1.Hmotnost;

                    this.Planety.Remove(pl1);
                }
                
                return true;
            }

            return false;
        }
    }
}
