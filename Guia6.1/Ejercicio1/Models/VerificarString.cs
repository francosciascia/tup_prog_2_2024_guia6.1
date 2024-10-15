using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class VerificarString : ITExto
    {

        public string VerificarTexto(string s)
        {
            string textoNormalizado = s.Replace("-", "").Replace(" ", "").ToUpper(); ;

            bool hasta2016 = textoNormalizado.Length == 6;
                if (hasta2016)
                {
                char n;
                for (int i = 0; i < textoNormalizado.Length && hasta2016 == true; i++)
                {
                    n = textoNormalizado[i];
                    hasta2016 &= (char.IsLetter(n) && n < 3 || 
                                  char.IsNumber(n) && n >= 3 && n < 6);
                }

                if (hasta2016)
                {
                    return $"Automóviles y camionetas hasta 2016  - {textoNormalizado}";
                }
                }

            bool post2016 = textoNormalizado.Length == 7;
                if (post2016)
                {
                    char n;
                    for (int i = 0; i < textoNormalizado.Length && post2016 == true; i++)
                    {
                        n = textoNormalizado[i];
                        post2016 &= (char.IsLetter(n) && n < 2 || 
                                     char.IsNumber(n) && n >= 2 && n < 5 || 
                                     char.IsLetter(n) && n >= 5 && n < 7);
                    }
                }
                if (hasta2016)
                {
                return $"Automóviles y camionetas desde 2016  - {textoNormalizado} ";
                }

            bool moto = textoNormalizado.Length == 8; // aa 233 aaa
                if (moto)
                {
                    char n;
                    for (int i = 0; i<textoNormalizado.Length && moto == true; i++)
                    {
                        n = textoNormalizado[i];
                        post2016 &= (char.IsLetter(n) && n < 2 || 
                                     char.IsNumber(n) && n >= 2 && n < 5 || 
                                     char.IsLetter(n) && n >= 5 && n < 8);
                    }
                }

                if (moto)
                {
                    return $"Moto - {textoNormalizado}";
                }

             bool acoplado = textoNormalizado.Length == 6;
                if (acoplado)
                {
                    char n;
                    for (int i = 0; i<textoNormalizado.Length && acoplado == true; i++)
                    {
                        n = textoNormalizado[i];
                        acoplado &= (char.IsLetter(n) && n < 2 || 
                                     char.IsNumber(n) && n >= 2 && n < 6);

                    }

                }
                if (acoplado) { return $"Acoplado - {textoNormalizado}"; } 


                return $"   No reconocido - {textoNormalizado} | ";
                }
            }
        }
