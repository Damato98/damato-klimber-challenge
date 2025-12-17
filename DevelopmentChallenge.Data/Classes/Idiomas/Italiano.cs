using DevelopmentChallenge.Data.Classes.FormasGeometricas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Italiano : IIdioma
    {
        public Italiano() { }

        public const int Id = 3;

        public string ListaVacia => "<h1>Lista di forme vuota!</h1>";

        public string ReporteFormas => "<h1>Rapporto delle forme</h1>";

        public string Total => "TOTALE:<br/>";

        public string Perimetro => "Perimetro ";

        public string Formas => "forme";

        public string Area => "Area ";

        public string TraducirForma(IFormaGeometrica tipo, int cantidad)
        {
            switch (tipo) //TODO: MEJORAR ESTO PARA QUE NO SEA UN SWITCH Y UNIFICAR LOGICA ENTRE IDIOMAS PARA REDUCIR CODIGO
            {
                case Cuadrado c:
                    return cantidad == 1 ? "Quadrato" : "Quadrati";
                case Circulo o:
                    return cantidad == 1 ? "Cerchio" : "Cerchi";
                case TrianguloEquilatero te:
                    return cantidad == 1 ? "Triangolo" : "Triangoli";
                case Trapecio tr:
                    return cantidad == 1 ? "Trapezio" : "Trapezi";
                case Rectangulo r:
                    return cantidad == 1 ? "Rettangolo" : "Rettangoli";
            }

            return string.Empty;
        }
    }
}
