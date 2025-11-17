namespace CapaMOD
{
    public class Empleado : Persona
    {
        private string cargo;
        private int salario;

        public string Cargo { get => cargo; set => cargo = value; }
        public int Salario { get => salario; set => salario = value; }

        public Empleado() : base() { }

        public Empleado(int id, string nombre, string cargo, int salario) : base(id, nombre)
        {

            this.cargo = cargo;
            this.salario = salario;
        }


    }
}
