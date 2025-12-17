/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Classes.FormasGeometricas;
using DevelopmentChallenge.Data.Classes.Idiomas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometricaManager
    {
        public FormaGeometricaManager()
        {
        }

        public static string Imprimir(IList<IFormaGeometrica> formas, int indiceIdioma) //SE IMPLEMENTO UNA SOBRECARGA DEL METODO DEBIDO A LOS TESTS QUE YA EXISTIAN
        {
            IIdioma idioma;
            switch (indiceIdioma)
            {
                case Castellano.Id:
                    idioma = new Castellano();
                    break;
                case Ingles.Id:
                    idioma = new Ingles();
                    break;
                case Italiano.Id:
                    idioma = new Italiano();
                    break;
                default: // default es inglés
                    idioma = new Ingles();
                    break;
            }

            return Imprimir(formas, idioma);
        }

        public static string Imprimir(IList<IFormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.ListaVacia);
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idioma.ReporteFormas);

                Dictionary<int, int> numerosFormas = new Dictionary<int, int>();
                Dictionary<int, decimal> areasFormas = new Dictionary<int, decimal>();
                Dictionary<int, decimal> perimetrosFormas = new Dictionary<int, decimal>();

                foreach (var forma in formas)
                {
                    if (numerosFormas.ContainsKey(forma.tipo))
                    {
                        numerosFormas[forma.tipo]++;
                        areasFormas[forma.tipo] += forma.CalcularArea();
                        perimetrosFormas[forma.tipo] += forma.CalcularPerimetro();
                    }
                    else
                    {
                        numerosFormas[forma.tipo] = 1;
                        areasFormas[forma.tipo] = forma.CalcularArea();
                        perimetrosFormas[forma.tipo] = forma.CalcularPerimetro();
                    }
                }

                foreach (var tipo in numerosFormas.Keys)
                    sb.Append(ObtenerLinea(numerosFormas[tipo], areasFormas[tipo], perimetrosFormas[tipo], formas.First(x => x.tipo == tipo), idioma)); //TODO: MEJORAR EL FORMAS.FIRST POR OTRA ALTERNATIVA MAS LIMPIA

                // FOOTER
                sb.Append(idioma.Total);
                sb.Append(numerosFormas.Sum(x => x.Value) + " " + idioma.Formas + " ");
                sb.Append(idioma.Perimetro + perimetrosFormas.Sum(x => x.Value).ToString("#.##") + " ");
                sb.Append(idioma.Area + areasFormas.Sum(x => x.Value).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, IFormaGeometrica tipo, IIdioma idioma)
        {
            if (cantidad > 0)
                return $"{cantidad} {idioma.TraducirForma(tipo, cantidad)} | {idioma.Area}{area:#.##} | {idioma.Perimetro}{perimetro:#.##} <br/>";

            return string.Empty;
        }
    }
}
