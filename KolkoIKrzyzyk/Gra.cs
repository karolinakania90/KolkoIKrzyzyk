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

        public Gra()
        {
            macierzGry = new string[3, 3];
        }

        public void LosujRuch(string symbol)
        {
            int poleX;
            int poleY;

            poleX = new Random().Next(0, 3);
            poleY = new Random().Next(0, 3);

            while (!string.IsNullOrEmpty(macierzGry[poleX, poleY]) && obecnyRuch != 9)
            {
                poleX = new Random().Next(0, 3);
                poleY = new Random().Next(0, 3);
            }
            macierzGry[poleX, poleY] = symbol;
            obecnyRuch++;
        }

        public void KolejnyRuch(int x, int y, string symbol)
        {
            macierzGry[x, y] = symbol;
        }
    }
}
