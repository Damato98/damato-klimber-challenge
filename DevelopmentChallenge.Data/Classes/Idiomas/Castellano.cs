using DevelopmentChallenge.Data.Classes.FormasGeometricas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Castellano : IIdioma
    {
        public Castellano() { }

        public const int Id = 1;

        public string ListaVacia => "<h1>Lista vacía de formas!</h1>";
        public string ReporteFormas => "<h1>Reporte de Formas</h1>";
        public string Total => "TOTAL:<br/>";
        public string Perimetro => "Perimetro ";
        public string Formas => "formas";
        public string Area => "Area ";

        public string TraducirForma(IFormaGeometrica tipo, int cantidad)
        {
            switch (tipo) //TODO: MEJORAR ESTO PARA QUE NO SEA UN SWITCH Y UNIFICAR LOGICA ENTRE IDIOMAS PARA REDUCIR CODIGO
            {
                case Cuadrado c:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case Circulo o:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case TrianguloEquilatero te:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
                case Trapecio tr:
                    return cantidad == 1 ? "Trapecio" : "Trapecios";
                case Rectangulo r:
                    return cantidad == 1 ? "Rectangulo" : "Rectangulos";
            }

            return string.Empty;
        }
    }
}
