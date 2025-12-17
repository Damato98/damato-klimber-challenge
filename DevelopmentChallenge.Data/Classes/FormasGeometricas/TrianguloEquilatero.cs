using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public int tipo => 2;
        public decimal lado { get; set; }

        public TrianguloEquilatero(decimal _lado)
        {
            this.lado = _lado;
        }

        public decimal CalcularArea()
        {
            decimal ladoElevado = this.lado * this.lado;
            return ((decimal)Math.Sqrt(3) / 4) * ladoElevado;
        }

        public decimal CalcularPerimetro()
        {
            return this.lado * 3;
        }
    }
}
