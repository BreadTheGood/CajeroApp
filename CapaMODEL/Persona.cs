namespace CapaMODEL
{
    public class Persona
    {
        private int id;
        private string nombre;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        public Persona()
        {

        }
        public Persona(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

    }
}
