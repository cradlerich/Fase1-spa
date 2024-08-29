using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase1_spa
{
    public class Controller
    {
        private Dictionary<string, double> servicios;
        private Dictionary<int, double> descuentos;

        public Controller()
        {
            InicializarValores();
        }

        private void InicializarValores()
        {
            servicios = new Dictionary<string, double>
        {
            { "Corte y cepillado", 60000 },
            { "Corte, cepillado y uñas", 90000 },
            { "Uñas en acrílico y cejas", 100000 },
            { "Uñas en acrílico, maquillaje y cejas", 140000 }
        };

            descuentos = new Dictionary<int, double>
        {
            { 1, 0.15 },
            { 2, 0.15 },
            { 3, 0.10 },
            { 4, 0.10 },
            { 5, 0.05 },
            { 6, 0.05 }
        };
        }
        // Método para crear un objeto ServiceModel basado en el servicio seleccionado y el estrato
        public ServiceModel CrearServicio(string tipoServicio, int estrato)
        {
            var servicio = new ServiceModel
            {
                Servicio = tipoServicio,
                Precio = servicios[tipoServicio],
                //El método ContainsKey se utiliza en colecciones de tipo Dictionary en C# para verificar si un diccionario contiene una clave específica
                //Es un método que devuelve true si el diccionario contiene un elemento con la clave especificada, y false si no la contiene.
                Descuento = descuentos.ContainsKey(estrato) ? descuentos[estrato] : 0 
            };

            return servicio;
        }
    }
}
