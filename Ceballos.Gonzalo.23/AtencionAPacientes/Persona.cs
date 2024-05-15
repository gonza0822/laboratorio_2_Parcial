namespace AtencionAPacientes
{
    public abstract class Persona
    {
        protected string apellido;
        protected string? barrioResidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public Persona(string apellido, string barrioResidencia, DateTime nacimiento, string nombre)
        {
            this.apellido = apellido;
            this.barrioResidencia = barrioResidencia;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public Persona(string apellido, DateTime nacimiento, string nombre)
        {
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return $"{this.apellido}, {this.nombre}";
            }
        }

        public override string ToString()
        {
            return $"{this.apellido}, {this.nombre}";
        }

        public string FichaPersonal(Persona p)
        {
            string barrioP = "";
            if (p.barrioResidencia is not null)
            {
                barrioP = p.barrioResidencia;
            }

            return $"{p.apellido}, {p.nombre}\n" +
                $"EDAD: {p.Edad}\n" +
                $"{barrioP}";
        }
    }
}
