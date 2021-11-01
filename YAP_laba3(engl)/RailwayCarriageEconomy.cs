using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    public class RailwayCarriageEconomy : RailwayCarriage
    {
        private int KolWindows;
        public void SetWindows(int a) { KolWindows = a; }
        public int GetWindows() { return KolWindows; }
       
        public RailwayCarriageEconomy(int a, int b, int c): base(a,b)
        {
            SetPeople(a); SetBaggage(b); KolWindows=c;
        }
        public override void СonvenienceFactor()
        {
            SetLevel(GetPeople() * 5 + GetBaggage() * 10+KolWindows*20);
        }
    }
}
