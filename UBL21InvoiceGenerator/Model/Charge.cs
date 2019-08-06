using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBL21InvoiceGenerator.Model
{
    public class Charge
    {
        Int32 id { get; set; }
        Boolean Indicator {
            get
            {
                return true;
            }
        }
        String Reason {
            get
            {
                return "Charge reason";
            }
        }
        Decimal Factor {
            get
            {
                return random.Next(5, 20);
            }
        }
        Decimal Amount {
            get {
                return (BaseAmount * Factor) /100;
            }
        }
        Decimal BaseAmount {
            get
            {
                return random.Next(10000, 100000);
            }
        }

        private Random random;

        public Charge()
        {
            random = new Random(Environment.TickCount);
        }

    }
}
