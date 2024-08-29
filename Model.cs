using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_spa
{
    // ServiceModel.cs
    public class ServiceModel
    {
        public string Servicio { get; set; }
        public double Precio { get; set; }
        public double Descuento { get; set; }

        public double CalcularValorFinal()
        {
            return Precio - (Precio * Descuento);
        }
    }

}
