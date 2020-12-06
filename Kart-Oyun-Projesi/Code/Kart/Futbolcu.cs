using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart
{
    public class Futbolcu : Sporcu
    {

        public int kaleciKarsiKarsiya { get; set; }
        public int penalti { get; set; }
        public int serbestVurus { get; set; }
        //public bool kartKullanildiMi { get; set; }

        public Futbolcu()
        {

        }

        public Futbolcu(string futbolcuAdi, string futbolcuTakim, int kaleciKarsiKarsiya, int penalti, int serbestVurus) : base(futbolcuAdi, futbolcuTakim)
        {
            this.kaleciKarsiKarsiya = kaleciKarsiKarsiya;
            this.penalti = penalti;
            this.serbestVurus = serbestVurus;
        }

        public override int SporcuPuaniGoster(int deger)
        {
            int[] dizi = { kaleciKarsiKarsiya, penalti, serbestVurus };
            return dizi[deger];
        }

        public override bool kartKullanildiMi(int[] dizi, int deger)
        {
            return base.kartKullanildiMi(dizi, deger);
        }
    }
}