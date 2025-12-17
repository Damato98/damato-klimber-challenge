using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Rectangulo : IFormaGeometrica
    {
        public int tipo => 5;
        public decimal lado { get; set; }
        public decimal altura { get; set; }


        public Rectangulo(decimal _base, decimal _altura) 
        {
            this.lado = _base;
            this.altura = _altura;
        }

        public decimal CalcularArea()
        {
            return lado * altura;
        }

        public decimal CalcularPerimetro()
        {
            return 2 * (lado + altura);
        }
    }
}
