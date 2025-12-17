using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Cuadrado : IFormaGeometrica
    {
        public int tipo => 1;

        public decimal lado { get; set; }

        public Cuadrado(decimal _lado) 
        {
            this.lado = _lado;
        }

        public decimal CalcularArea()
        {
            decimal ladoElevado = this.lado * this.lado;
            return ladoElevado;
        }

        public decimal CalcularPerimetro()
        {
            return this.lado * 4;
        }
    }
}
