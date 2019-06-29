using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KolkoIKrzyzyk.Test
{
    [TestClass]
    public class GraTest
    {
        public Gra gra;
        public GraTest()
        {
            gra = new Gra();
        }

        [TestMethod]
        public void Rozgrywka_1()
        {
            //x
            gra.KolejnyRuch(0, 0);
            //o
            gra.KolejnyRuch(1, 0);
            //x
            gra.KolejnyRuch(0, 1);
            //o
            gra.KolejnyRuch(2, 0);
            //x
            gra.KolejnyRuch(0, 2);

            Assert.IsTrue(gra.SprawdzKtoWygral().Symbol == "X");
        }
    }
}
