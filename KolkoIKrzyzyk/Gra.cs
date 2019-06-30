using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolkoIKrzyzyk
{
    public class Gra
    {
        private string[,] macierzGry;

        private int obecnyRuch = 0;

        public bool KoniecGry { get { return obecnyRuch == 9; } }

        private string symbolX = "X";

        private string symbolO = "0";

        public Gra()
        {
            macierzGry = new string[3, 3];
        }

        public Ruch LosujRuch()
        {
            int poleX;
            int poleY;
            poleX = new Random().Next(3);
            poleY = new Random().Next(3);

            bool szukajPustegoPola = true;

            while (szukajPustegoPola)
            {                
                if (macierzGry[poleX, poleY] == null)
                {
                    macierzGry[poleX, poleY] = symbolO;
                    szukajPustegoPola = false;
                }
                else
                {
                    poleX = new Random().Next(3);
                    poleY = new Random().Next(3);
                }
            }

            obecnyRuch++;

            return new Ruch()
            {
                Pole = new Pole()
                {
                    X = poleX,
                    Y = poleY
                },
                Symbol = symbolO
            };
        }

        public string KolejnyRuch(int x, int y)
        {
            macierzGry[x, y] = symbolX;
            obecnyRuch++;

            return macierzGry[x, y];
        }

        public Wygrana SprawdzKtoWygral()
        {
            if (macierzGry[0, 0] != null &&
                macierzGry[0, 0] == macierzGry[0, 1]
                && macierzGry[0, 1] == macierzGry[0, 2]
                && macierzGry[0, 0] == macierzGry[0, 2])
            {
                return new Wygrana()
                {
                    Symbol = macierzGry[0, 0],
                    Poczatkowe = new Pole()
                    {
                        X = 0,
                        Y = 0
                    },
                    Koncowe = new Pole()
                    {
                        X = 0,
                        Y = 2
                    }
                };
            }
            else if (macierzGry[1, 0] != null &&
                  macierzGry[1, 0] == macierzGry[1, 1]
                  && macierzGry[1, 1] == macierzGry[1, 2]
                  && macierzGry[1, 0] == macierzGry[1, 2])
            {
                return new Wygrana()
                {
                    Symbol = macierzGry[1, 0],
                    Poczatkowe = new Pole()
                    {
                        X = 1,
                        Y = 0
                    },
                    Koncowe = new Pole()
                    {
                        X = 1,
                        Y = 2
                    }
                };
            }
            else if (macierzGry[2, 0] != null &&
                    macierzGry[2, 0] == macierzGry[2, 1]
                 && macierzGry[2, 1] == macierzGry[2, 2]
                 && macierzGry[2, 0] == macierzGry[2, 2])
            {
                return new Wygrana()
                {
                    Symbol = macierzGry[2, 0],
                    Poczatkowe = new Pole()
                    {
                        X = 2,
                        Y = 0
                    },
                    Koncowe = new Pole()
                    {
                        X = 2,
                        Y = 2
                    }
                };
            }


            return null;
        }
    }
}
