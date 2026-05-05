using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public abstract class Sale
    {
        public decimal montoVenta;
       
        public Sale(decimal montoVenta)
        {
            this.montoVenta = montoVenta;
        }

        public virtual decimal CalculateTotal()
        {
            return montoVenta;
        }
    }
}
