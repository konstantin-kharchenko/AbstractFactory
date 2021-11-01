using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    class Fabrica2 : IFabrica
    {
        RailwayCarriage IFabrica.CreateRail(int[] a)
        {
            //a[0]-кол людей
            //a[1]-кол багажа
            //a[2]-кол окон
            return new RailwayCarriageEconomy(a[0], a[1], a[2]);
        }

        TypeRailway IFabrica.CreateType(int c)
        {
            return new ReservedSeat(c);
        }

        string IFabrica.WhatIs()
        {
            return "Эконом, плацкарт";
        }
    }
}
