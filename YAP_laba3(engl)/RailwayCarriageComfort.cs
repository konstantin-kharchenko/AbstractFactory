using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    public class RailwayCarriageComfort:RailwayCarriageEconomy
    {
        private int KolSockets;
        public void SetSockets(int a) { KolSockets = a; }
        public int GetSockets() { return KolSockets; }
        public RailwayCarriageComfort(int a, int b, int c,int d): base(a,b,c)
        {
            SetPeople(a); SetBaggage(b); SetWindows(c);KolSockets = d;
        }
        public override void СonvenienceFactor()
        {
            SetLevel(GetPeople() *5 + GetBaggage() * 10 + GetWindows() * 20 + KolSockets*40);
        }
    }
}
