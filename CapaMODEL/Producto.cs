namespace CapaMODEL
{
    public class Producto
    {
        private int id;
        private string nombre;
        private int precio;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }

        public Producto() { }

        public Producto(int id, string nombre, int precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
