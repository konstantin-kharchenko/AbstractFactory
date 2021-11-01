using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    class Fabrica3 : IFabrica
    {
        RailwayCarriage IFabrica.CreateRail(int[] a)
        {
            //a[0]-кол людей
            //a[1]-кол багажа
            //a[2]-кол окон
            //a[3]-кол разеток
            return new RailwayCarriageComfort(a[0], a[1], a[2], a[3]);
        }
        TypeRailway IFabrica.CreateType(int c)
        {
            return new Coupe(c);
        }
        string IFabrica.WhatIs()
        {
            return "Комфорт, купе";
        }
    }
}
