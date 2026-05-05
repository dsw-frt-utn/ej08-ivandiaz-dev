using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if(code == null)
            {
                return "SIN-CODIGO";
            }

            string resultadoCode = code;
            resultadoCode = resultadoCode.Trim();
            resultadoCode = resultadoCode.ToUpper();
            resultadoCode = resultadoCode.Replace(" ", "-");

            return resultadoCode;
        }
    }
}
