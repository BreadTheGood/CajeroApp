namespace CapaMODEL
{
    public class Empleado : Persona
    {
        private string cargo;
        private string salario;

        public string Cargo { get => cargo; set => cargo = value; }
        public string Salario { get => salario; set => salario = value; }

        public Empleado() : base() { }

        public Empleado(int id, string nombre, string cargo, string salario) : base(id, nombre)
        {

            this.cargo = cargo;
            this.salario = salario;
        }
    }
}
