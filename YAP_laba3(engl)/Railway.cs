using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    public class Railway
    {
        private double LEVEL1, LEVEL2;
        private RailwayCarriage railwaycarriage;
        private TypeRailway type;
        int scores;int[] a;
        private IFabrica newfabrica;
        public Railway(IFabrica fabrica, int[]a, int scores )
        {
            railwaycarriage = fabrica.CreateRail(a);
            type = fabrica.CreateType(scores);
            newfabrica = fabrica;
            this.scores = scores;
            this.a = a;
        }

        public void NewCreateRailway(int[] a)
        {
            railwaycarriage = newfabrica.CreateRail(a);
            this.a = a;
        }

        public double Coolness()
        {
            railwaycarriage.СonvenienceFactor();
            LEVEL1 = railwaycarriage.GetLevel();
            LEVEL2= type.Getter();
            LEVEL1 += LEVEL2;
            return LEVEL1;
        }

        public int ReturnPeopleCount()
        {
            return railwaycarriage.GetPeople();
        }

        public IFabrica ReturnFabrica()
        {
            return newfabrica;
        }

        public int ReturnScores()
        {
            return scores;
        }

        public int[] ReturnInfo()
        {
            return a;
        }

        public string ReturnWhoIs()
        {
            return newfabrica.WhatIs();
        }
        public bool IsKolPeopleNormal(int x, int y)
        {
            if (railwaycarriage.IsKolPeopleNormal(x, y)) return true;
            return false;
        }
    }
}
