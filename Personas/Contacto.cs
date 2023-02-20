namespace Personas
{
    internal class Contacto : Persona
    {
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value.Replace(" ", "").Replace("-", "");
            }
        }

        public Contacto() : base()
        {
            telefono = string.Empty;
        }
        public Contacto(string nombre, DateTime? fechaNacimiento, string telefono) : base(nombre, fechaNacimiento)
        {
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return base.ToString() + " " + telefono;
        }
    }
}
