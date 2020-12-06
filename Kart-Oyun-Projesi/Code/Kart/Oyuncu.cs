using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart
{
   abstract public class Oyuncu
    {
        public int oyuncuID { get; set; }
        public string oyuncuAdi { get; set; }
        public int skor { get; set; }

        public Oyuncu(int oyuncuID, string oyuncuAdi, int skor)
        {
            this.oyuncuID = oyuncuID;
            this.oyuncuAdi = oyuncuAdi;
            this.skor = skor;
        }

        public Oyuncu()
        {
        }

        abstract public int SkorGoster(int skor);

        public virtual int kartSec(int[] kartDizi ,int deger)
        {
            Futbolcu f = new Futbolcu();
            Basketbolcu b = new Basketbolcu();



            if (deger % 2 == 0)
            {
                if (f.kartKullanildiMi(kartDizi, deger))
                {

                    return deger;
                }
            }
            else
            {
                if (b.kartKullanildiMi(kartDizi, deger))
                {
                    return deger;
                }
            }
            return -1;
        }
    }
}