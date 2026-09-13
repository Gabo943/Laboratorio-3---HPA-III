using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Utilidades
    {
        public static bool EsCorreoValido(string correo)
        {
            if (EstaEnBlanco(correo))
            {
                return false;
            }
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        public static bool EstaEnBlanco(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
    }
}
