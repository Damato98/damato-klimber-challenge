using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IFormaGeometrica
    {
        int tipo { get; }
        decimal lado { get; set; }

        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
