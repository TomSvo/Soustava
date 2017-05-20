using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoustavaFormApp
{
    public class Game
    {
        public List<Planeta> Planety { get; set; }

        public Game()
        {
            this.Planety = new List<Planeta>();
        }
        public void Update()
        {
            for (int i = 0; i < Planety.Count; i++)
            {
                for (int a = 0; a < Planety.Count; a++) ;
            }
        }
        public void Vypocti()
        {

        }
    }
}
