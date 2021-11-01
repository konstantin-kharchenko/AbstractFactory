using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    class Fabrica4 : IFabrica
    {
        RailwayCarriage IFabrica.CreateRail(int[] a)
        {
            return new RailwayCarriageComfort(a[0], a[1], a[2], a[3]);
        }

        TypeRailway IFabrica.CreateType(int c)
        {
            return new ReservedSeat(c);
        }
        string IFabrica.WhatIs()
        {
            return "Комфорт, плацкарт";
        }
    }
}
