using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    public abstract class RailwayCarriage//абстрактный класс для экононома и комфорта
    {
        
        public RailwayCarriage (int a, int b)
        {
            KolPeople = a;KolBaggage = b;
        }

        private int KolPeople;
        private int KolBaggage;
        private double LevelComfort;

//сеторы
        public void SetPeople(int a) { KolPeople = a; }
        public void SetBaggage(int a) { KolBaggage = a; }
        public void SetLevel(double a) { LevelComfort = a; }

//геторы
        public int GetPeople() { return KolPeople; }
        public int GetBaggage() { return KolBaggage; }
        public double GetLevel() { return LevelComfort; }

//проверяет нормальное ли количество людей
        public bool IsKolPeopleNormal(int x, int y)
        {
            return (x <= GetPeople() && y >= GetPeople());
        }

//крутость того или иного вагона
        public abstract void СonvenienceFactor();
    }
}
