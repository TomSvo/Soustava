using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoustavaFormApp
{
    public class Planeta
    {



        public double Velikost { get; set; }

        public double RychlostX { get; set; }
        public double RychlostY { get; set; }

        public double PositionX { get; set; }

        public double PositionY { get; set; }

        public Planeta(double velikost, double rychlostX, double rychlostY, double positionX, double positionY)
        {
            this.Velikost = velikost;
            this.RychlostX = rychlostX;
            this.RychlostY = rychlostY;
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        //potom zavolat new planeta a nasypat do ni hodnoty
        //udělat kruh a rozrotovat ho
    }
}
