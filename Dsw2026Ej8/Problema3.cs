using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Problema3
    {
        public static string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            copia++;

            Product productoCopia = product;
            productoCopia.modificarDescripcion("Este es un producto modificado");

            return $"{originalValue}-{copia}-{productoCopia.description}";
        }
    }
}
