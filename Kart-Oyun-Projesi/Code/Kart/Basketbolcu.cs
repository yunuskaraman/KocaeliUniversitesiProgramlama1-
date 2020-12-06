using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart
{
    public class Basketbolcu : Sporcu
    {
       
        public int ikilik { get; set; }
        public int ucluk { get; set; }
        public int serbestAtis { get; set; }

        public Basketbolcu()
        {

        }

        public Basketbolcu(string basketbolcuAdi, string basketbolcuTakim, int ikilik, int ucluk, int serbestAtis) : base(basketbolcuAdi, basketbolcuTakim)
        {
            this.ikilik = ikilik;
            this.ucluk = ucluk;
            this.serbestAtis = serbestAtis;
        }



        public override int SporcuPuaniGoster(int deger)
        {
            //base.SporcuPuaniGoster();
            int[] dizi = { ikilik, ucluk, serbestAtis };
            return dizi[deger];
        }


        public override bool kartKullanildiMi(int[] dizi, int deger)
        {
            return base.kartKullanildiMi(dizi, deger);
        }
    }

}
