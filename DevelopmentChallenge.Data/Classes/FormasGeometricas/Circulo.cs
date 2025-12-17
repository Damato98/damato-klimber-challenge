using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo : IFormaGeometrica
    {
        public int tipo => 3;
        public decimal lado { get; set; }

        public Circulo(decimal _diametro) 
        {
            this.lado = _diametro;
        }

        public decimal CalcularArea()
        {
            decimal radio = this.lado / 2;
            decimal rElevado = radio * radio;
            return (decimal)Math.PI * rElevado;
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * this.lado;
        }
    }
}
