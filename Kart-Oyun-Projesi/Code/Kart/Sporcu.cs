using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kart
{
    public class Sporcu
    {

        public string sporcuIsim { get; set; }
        public string sporcuTakim { get; set; }

        public Sporcu(string sporcuIsim, string sporcuTakim)
        {

            this.sporcuIsim = sporcuIsim;
            this.sporcuTakim = sporcuTakim;
        }

        public Sporcu()
        {

        }

        public virtual int SporcuPuaniGoster(int deger)
        {
            return deger;
        }


        public virtual Boolean kartKullanildiMi(int[] dizi, int deger)
        {
            //kartdizi =0,1,2,3,4,5,6,7


            

            for (int i = 0; i <= 8; i++)
            {
                if (dizi[i] == deger)
                    return true;
                else
                    if (dizi[deger] == -1)
                        break;
            }
            return false;
        }


        public override string ToString()
        {
            return sporcuIsim + sporcuTakim;
        }

    }
}