using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ariketa2
{
    public class Zenbakiak
    {
        public float a { get; set; }
        public float b { get; set; }
        public float c { get; set; }
        public float d { get; set; }

        public Zenbakiak()
        {

        }
        public float eragiketa()
        {
            float emaitza = 0;
            emaitza = (a + (2 * b) + (3 * c) + (4 * d)) / 4;
            return emaitza;
        }
    }
}
