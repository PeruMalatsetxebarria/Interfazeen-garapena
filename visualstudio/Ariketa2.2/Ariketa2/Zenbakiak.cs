using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2
{
    public class Zenbakiak
    {
        public float zenbakiak { get; set; }

        public Zenbakiak()
        {

        }
        public static float eragiketa(List<Zenbakiak> zenbakiak)
        {
            float emaitza = 0;
            emaitza = (zenbakiak[0].zenbakiak + (2 * zenbakiak[1].zenbakiak) + (3 * zenbakiak[2].zenbakiak) + (4 * zenbakiak[3].zenbakiak)) / 4;
            return emaitza;
        }
    }
}
