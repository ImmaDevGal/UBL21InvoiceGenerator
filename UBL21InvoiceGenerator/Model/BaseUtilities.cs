using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator.Model
{
    public class BaseUtilities
    {
        public Random random;

        public BaseUtilities()
        {
            random = new Random(Environment.TickCount);
        }
    }
}
