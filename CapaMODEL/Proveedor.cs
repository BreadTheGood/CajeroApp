namespace CapaMODEL
{
    public class Proveedor : Persona
    {

        private string telefono;
        private string mail;

        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }

        public Proveedor() : base()
        {

        }

        public Proveedor(int id, string nombre, string telefono, string mail) : base(id, nombre)
        {
            this.telefono = telefono;
            this.mail = mail;
        }
    }
}
