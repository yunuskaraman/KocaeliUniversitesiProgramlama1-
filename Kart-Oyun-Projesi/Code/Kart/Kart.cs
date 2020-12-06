using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kart
{
    class Kart
    {
        public Sporcu sporcu { get; set; }
        public bool isUsing = false;
        public Kart(Sporcu sporcu)
        {
            this.sporcu = sporcu;
        }

    }
}
