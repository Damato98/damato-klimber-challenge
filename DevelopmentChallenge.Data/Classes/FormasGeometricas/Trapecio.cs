using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Trapecio : IFormaGeometrica
    {
        public int tipo => 4;

        public decimal baseMayor { get; set; }
        public decimal baseMenor { get; set; }
        public decimal lado { get; set; }
        public decimal ladoDer { get; set; }


        public Trapecio(decimal _baseMayor, decimal _baseMenor, decimal _ladoIzd, decimal _ladoDer)
        {
            this.baseMayor = _baseMayor;
            this.baseMenor = _baseMenor;
            this.lado = _ladoIzd;
            this.ladoDer = _ladoDer;
        }

        public decimal CalcularArea()
        {
            decimal dif = this.baseMayor - this.baseMenor;
            decimal ladoElevado = this.lado * this.lado;
            decimal ladoDerElevado = this.ladoDer * this.ladoDer;
            decimal difElevado = dif * dif;
            decimal x = (ladoElevado - ladoDerElevado + difElevado) / (2 * dif);
            decimal h2 = ladoElevado - (x * x);
            decimal altura = (decimal)Math.Sqrt((double)h2);

            return ((this.baseMayor + this.baseMenor) * altura) / 2;
        }

        public decimal CalcularPerimetro()
        {
            return this.baseMayor + this.baseMenor + this.lado + this.ladoDer;
        }
    }
}
