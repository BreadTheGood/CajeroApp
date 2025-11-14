namespace CapaMOD
{
    public class Usuario : Persona
    {
        private string tipoUsuario;

        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public Usuario() : base()
        {

        }

        public Usuario(int id, string nombre, string tipoUsuario) : base(id, nombre)
        {

            this.tipoUsuario = tipoUsuario;

        }

    }
}
