using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        public string description;

        public Product(string description)
        {
            this.description = description;
        }

        public void modificarDescripcion(string description)
        {
            this.description = description;
        }
    }
}
