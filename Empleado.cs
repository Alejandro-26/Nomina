using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaEmpleados
{
    public class Empleado
    {

        private string identificacion;
        private string nombres;
        private string cargo;
        private Decimal valorDia;

        // Referencias Get / Set
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Cargo { get; set; }
        public decimal ValorDia  { get; set; }

    }
}
