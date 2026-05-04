using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Problema4
    {
        public static double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidad = 0;

            void verificarNota(int? nota)
            {
                if(nota.HasValue && nota >= 0 && nota <= 10)
                {
                    suma += nota.Value;
                    cantidad++;
                }
            }

            verificarNota(nota1);
            verificarNota(nota2);
            verificarNota(nota3);

            return cantidad == 0 ? 0 : (double)suma / cantidad;
        }
    }
}
