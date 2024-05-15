using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAPacientes
{
    public class Paciente : Persona
    {
        private string? diagnostico;

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioResidencia) : base(apellido, barrioResidencia, nacimiento, nombre)
        {
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { this.diagnostico = value; }
        }
        internal override string FichaExtra()
        {
            return $"Recide en {this.barrioResidencia}\n" +
                $"{this.diagnostico}";
        }
    }
}
