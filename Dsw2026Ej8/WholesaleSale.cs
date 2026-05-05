using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal montoVenta) : base(montoVenta) { }

        public override decimal CalculateTotal()
        {
            return montoVenta*0.9m;
        }
    }
}
