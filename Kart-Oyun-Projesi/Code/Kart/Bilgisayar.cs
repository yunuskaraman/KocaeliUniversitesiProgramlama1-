using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kart
{
    class Bilgisayar : Oyuncu
    {
        public Bilgisayar()
        {
           
        }

        public Bilgisayar(int oyuncuID, string oyuncuAdi, int skor) : base(oyuncuID, oyuncuAdi, skor)
        {
        }

        public override int kartSec(int[] kartDizi,int deger)
        {
           
            return base.kartSec(kartDizi,deger);
        }

        public override int SkorGoster(int skor)
        {
            
            return this.skor += skor;
            
            
        }
    }
}