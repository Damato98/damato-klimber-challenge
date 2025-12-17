using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IIdioma
    {
        string ListaVacia { get; }
        string ReporteFormas { get; }
        string Total { get; }
        string Perimetro { get; }
        string Formas { get; }
        string Area { get; }

        string TraducirForma(IFormaGeometrica tipo, int cantidad);
    }
}
