using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaEmpleados
{
    public class Nomina
    {

        private int diasLaborales;
        private decimal valorDia;
        private int basico;


        // Referencias Get / Set
        public int DiasLaborales { get; set; }
        public decimal ValorDia { get; set; }
        public int Basico { get; set; }


        // Metodo para calcular nomina
        public Decimal CalculandoNomina (int DiasLaborales, decimal ValorDia)
        {
            Decimal TotalSalario = ValorDia * DiasLaborales;
            return TotalSalario;
        }


        // Metodo que retorna basico
        public int Devengado()
        {
            return this.basico;
        }

       
       
    }
}
