using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAPacientes
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string apellido, string nombre, DateTime nacimiento,  bool esResidente) : base(apellido, nacimiento, nombre)
        {
            this.esResidente = esResidente;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Consulta consulta in consultas)
            {
                sb.AppendLine(consulta.ToString());
            }
            string residente = "NO";
            if (this.esResidente)
            {
                residente = "SI";
            }
            return $"¿Finalizo residencia? {residente}/n" +
                $"ATENCIONES/n" +
                $"{sb.ToString()}";
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(consulta);
            return consulta;
        }
    }
}
