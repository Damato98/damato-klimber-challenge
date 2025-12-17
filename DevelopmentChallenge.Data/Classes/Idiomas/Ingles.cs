using DevelopmentChallenge.Data.Classes.FormasGeometricas;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Idiomas
{
    public class Ingles : IIdioma
    {
        public Ingles() { }

        public const int Id = 2;

        public string ListaVacia => "<h1>Empty list of shapes!</h1>";
        public string ReporteFormas => "<h1>Shapes report</h1>";
        public string Total => "TOTAL:<br/>";
        public string Perimetro => "Perimeter ";
        public string Formas => "shapes";
        public string Area => "Area ";

        public string TraducirForma(IFormaGeometrica tipo, int cantidad)
        {
            switch (tipo) //TODO: MEJORAR ESTO PARA QUE NO SEA UN SWITCH Y UNIFICAR LOGICA ENTRE IDIOMAS PARA REDUCIR CODIGO
            {
                case Cuadrado c:
                    return cantidad == 1 ? "Square" : "Squares";
                case Circulo o:
                    return cantidad == 1 ? "Circle" : "Circles";
                case TrianguloEquilatero te:
                    return cantidad == 1 ? "Triangle" : "Triangles";
                case Trapecio tr:
                    return cantidad == 1 ? "Trapezoid" : "Trapezoids";
                case Rectangulo r:
                    return cantidad == 1 ? "Rectangle" : "Rectangles";
            }

            return string.Empty;
        }
    }
}
