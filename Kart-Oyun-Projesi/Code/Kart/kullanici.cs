using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart
{
    class Kullanici : Oyuncu
    {
        
        public Kullanici()
        {
        }

        public Kullanici(int oyuncuID, string oyuncuAdi, int skor) : base(oyuncuID, oyuncuAdi, skor)
        {
        }

        public override int kartSec(int[] kartDizi,int deger)
        {
            return base.kartSec(kartDizi, deger);
        }
        public override int SkorGoster(int skor)
        {
            //Form1 fr = new Form1();
           return this.skor += skor;
        }
    }
}