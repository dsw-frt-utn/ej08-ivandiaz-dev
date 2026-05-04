using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static partial class ProductHelper
    {
        public static string FormatoPrecio(decimal price)
        {
            return price.ToString("C");
        }
    }
}
