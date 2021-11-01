using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAP_laba3_engl_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kk = true, kk2 = true; ; int a, b;
            List<Railway> vag = new List<Railway>();
            Railway v;
            StreamReader read = new StreamReader("read.txt");
            string lines;
            int[] info=new int[1];
            bool chouse = true;
            int go = 0;
            do {
                if (chouse)
                {
                    Console.WriteLine("собрать поезд самому или влять данные из файла?\n1) сам\n2) файл");
                    go = Convert.ToInt32(Console.ReadLine());
                    chouse = false;
                }
                if (go == 1)
                {
                    do
                    {
                        Console.WriteLine("Введите: \n1) Эконом\n2) Комфорт\n3)собрать поезд");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1)
                        {
                            info = new int[3];
                            Console.WriteLine("Сколько людей?");
                            info[0] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Сколько багажа?");
                            info[1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Сколько окон?");
                            info[2] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите: \n1) Купе\n2) Плацкарт");
                            b = Convert.ToInt32(Console.ReadLine());
                            if (b == 1)
                            {
                                Console.WriteLine("+ сколько к крутости будет давать купе?");
                                int c = Convert.ToInt32(Console.ReadLine());
                                v = new Railway(new Fabrica1(), info, c);
                                Console.WriteLine("рейтинг вагона: " + v.Coolness().ToString());
                                vag.Add(v);
                            }
                            if (b == 2)
                            {
                                Console.WriteLine("+ сколько к крутости будет давать плацкарт?");
                                int c = Convert.ToInt32(Console.ReadLine());
                                v = new Railway(new Fabrica2(), info, c);
                                Console.WriteLine("рейтинг вагона: " + v.Coolness().ToString());
                                vag.Add(v);
                            }
                        }
                        if (a == 2)
                        {
                            info = new int[4];
                            Console.WriteLine("Сколько людей?");
                            info[0] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Сколько багажа?");
                            info[1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Сколько окон?");
                            info[2] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Сколько разеток?");
                            info[3] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите: \n1) Купе\n2) Плацкарт");
                            b = Convert.ToInt32(Console.ReadLine());
                            if (b == 1)
                            {
                                Console.WriteLine("+ сколько к крутости будет давать купе?");
                                int c = Convert.ToInt32(Console.ReadLine());
                                v = new Railway(new Fabrica3(), info, c);
                                Console.WriteLine("рейтинг вагона: " + v.Coolness().ToString());
                                vag.Add(v);
                            }
                            if (b == 2)
                            {
                                Console.WriteLine("+ сколько к крутости будет давать плацкарт?");
                                int c = Convert.ToInt32(Console.ReadLine());
                                v = new Railway(new Fabrica4(), info, c);
                                Console.WriteLine("рейтинг вагона: " + v.Coolness().ToString());
                                vag.Add(v);
                            }
                        }
                        if (a == 3) { kk2 = false; }
                    } while (kk2);
                    go = 0;
                }
                else if (go == 2)
                {
                    do
                    {
                        lines = read.ReadLine();
                        int[] meaning = lines.Split(' ').Select(z => int.Parse(z)).ToArray();
                        if (meaning[0] == 1)
                        {
                            info = new int[3];
                            info[0] = meaning[1];
                            info[1] = meaning[2];
                            info[2] = meaning[3];
                            int c = meaning[4];
                            v = new Railway(new Fabrica1(), info, c);
                            Console.WriteLine("рейтинг вагона: " + v.Coolness().ToString());
                            vag.Add(v);
                        }
                        if (meaning[0] == 2)
                        {
                            info = new int[3];
                            info[0] = meaning[1];
                            info[1] = meaning[2];
                            info[2] = meaning[3];
                            int c = meaning[4];
                            v = new Railway(new Fabrica2(), info, c);
                            Console.WriteLine("рейтинг вагона: " + v.Coolness().ToString());
                            vag.Add(v);
                        }
                        if (meaning[0] == 3)
                        {
                            info = new int[4];
                            info[0] = meaning[1];
                            info[1] = meaning[2];
                            info[2] = meaning[3];
                            info[3] = meaning[4];
                            int c = meaning[5];
                            v = new Railway(new Fabrica3(), info, c);
                            Console.WriteLine("рейтинг вагона: " + v.Coolness().ToString());
                            vag.Add(v);
                        }
                        if (meaning[0] == 4)
                        {
                            info = new int[4];
                            info[0] = meaning[1];
                            info[1] = meaning[2];
                            info[2] = meaning[3];
                            info[3] = meaning[4];
                            int c = meaning[5];
                            v = new Railway(new Fabrica4(), info, c);
                            Console.WriteLine("рейтинг вагона: " + v.Coolness().ToString());
                            vag.Add(v);
                        }
                    } while (!read.EndOfStream);
                    go = 0;
                }
                else { chouse = true; continue; }
                bool kk3 = true;
                do {
                    Console.WriteLine("делаем ремонт в вагоне или может быть кто-то из пасажиров пришел?\n1) пасажиры\n2) ремонт\n3) едем до конечной");
                    int zx = Convert.ToInt32(Console.ReadLine());
                    if (zx == 1 || zx == 2)
                    {
                        Console.WriteLine("в каком вагоне?");
                        foreach (Railway railway in vag)
                        {
                            Console.WriteLine("Вагон: " + railway.ReturnWhoIs() + " => людей: " + railway.ReturnInfo()[0].ToString() + " => багаж: " + railway.ReturnInfo()[1].ToString() + " => рейтинг вагона: " + railway.Coolness().ToString());
                        }
                        int NumberOfRailway = Convert.ToInt32(Console.ReadLine());
                        int[] info2 = new int[4];
                        if (zx == 1)
                        {
                            Console.WriteLine("Сколько людей и багажа добавилось в вагон?");
                            Console.WriteLine("Людей");
                            info2[0] = Convert.ToInt32(Console.ReadLine())+vag[NumberOfRailway-1].ReturnInfo()[0];
                            Console.WriteLine("багажа");
                            info2[1] = Convert.ToInt32(Console.ReadLine())+ vag[NumberOfRailway - 1].ReturnInfo()[0];
                            info2[2] = vag[NumberOfRailway - 1].ReturnInfo()[2];
                            if(vag[NumberOfRailway - 1].ReturnInfo().Length>3)
                            info2[3] = vag[NumberOfRailway - 1].ReturnInfo()[3];
                        }
                        else if (zx == 2)
                        {
                            info2[0] = vag[NumberOfRailway - 1].ReturnInfo()[0];
                            info2[1] = vag[NumberOfRailway - 1].ReturnInfo()[1];
                            Console.WriteLine("Сколько окон добавилось в вагон?");
                            Console.WriteLine("окон");
                            info2[2] = Convert.ToInt32(Console.ReadLine());
                            if (vag[NumberOfRailway - 1].ReturnInfo().Length == 4)
                            {
                                Console.WriteLine("разеток");
                                info2[3] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        vag[NumberOfRailway - 1].NewCreateRailway(info2);
                    }
                    else if (zx == 3) { kk = false; kk3 = false; }
                }
                while (kk3);  
            }
            while (kk);
            foreach (Railway railway in vag)
            {
                Console.WriteLine("Вагон: "+ railway.ReturnWhoIs()+ " => людей: " + railway.ReturnInfo()[0].ToString() + " => багаж: " + railway.ReturnInfo()[1].ToString() + " => рейтинг вагона: "+ railway.Coolness().ToString());
            }
            Console.WriteLine("общее число людей и багажа в поезде:");
            int sumpeople = 0, sumbaggage = 0;
            foreach(Railway railway in vag) {
                sumpeople += railway.ReturnInfo()[0];
                sumbaggage += railway.ReturnInfo()[1];
            }
            Console.WriteLine("Людей: "+ sumpeople);
            Console.WriteLine("Багажа: " + sumbaggage);
            Console.WriteLine("SORT");
            vag.Sort((Railway fer, Railway sec) => fer.Coolness().CompareTo(sec.Coolness()));
            foreach(Railway railway in vag){
                Console.WriteLine("Вагон: " + railway.ReturnWhoIs() + " => рейтинг вагона: " + railway.Coolness().ToString());
            }
            Console.WriteLine("введите диапазон людей\nx: ");
            int x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y: ");
            int y= Convert.ToInt32(Console.ReadLine());
            foreach(Railway railway1 in vag)
            {
                if (railway1.IsKolPeopleNormal(x, y)) Console.WriteLine("Вагон: " + railway1.ReturnWhoIs() +" => подходит");
            }
            Console.ReadKey();
        }
    }
}
