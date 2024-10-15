using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Models
{
    internal class VerificarRegex : ITExto
    {
        public string VerificarTexto(string s)
        {
            // Verificar lo de formateada
            
            string textoNormalizado = s.Replace(" ", "").Replace("-", "").ToUpper();
            string patron = @"^[A-Z]{3}[0-9]{3}$";
            string patron1 = @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$";
            string patron2 = @"^[A-Z]{2}[0-9]{3}[A-Z]{3}$";
            string patron3 = @"^[A-Z]{2}[0-9]{4}$";

            Match match;
            match = Regex.Match(textoNormalizado, patron);
            if (match.Success)
            {
                return $"Automóviles y camionetas hasta 2016, {textoNormalizado}";
            }

            match = Regex.Match(textoNormalizado, patron1);
            if (match.Success)
            {
                return $"Automóviles y camionetas desde 2016, {textoNormalizado}";
            }

            match = Regex.Match(textoNormalizado, patron2);
            if (match.Success)
            {
                return $"Motocicleta, {textoNormalizado}";
            }

            match = Regex.Match(textoNormalizado, patron3);

            if (match.Success) 
            {
                return $"Acoplado, {textoNormalizado}";
            }

            return $"   No identificado {textoNormalizado}" + $"\n";
        }
    }
}
