using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditosGallegos
{
    class publicas
    {
        private static int id_tec;

        public static int Nombreid
        {
            get { return id_tec; }
            set { id_tec = value; }
        }
    }
}
