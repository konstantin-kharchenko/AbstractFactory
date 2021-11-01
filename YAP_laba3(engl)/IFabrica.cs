using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    public interface IFabrica
    {
        RailwayCarriage CreateRail(params int[] a);
        TypeRailway CreateType(int c);
        string WhatIs();
    }
}
