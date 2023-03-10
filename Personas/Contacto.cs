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
        public string Obtain_Data()
        {
            string line;
            char com = ',';
            Console.WriteLine("Type your name");
            line = Console.ReadLine();
            
            DateTime dateTime;
            bool validation = false;
            while (true)
            {
                Console.WriteLine("Type your birthdate format(DD/MM/YYY)");
                validation = DateTime.TryParse(Console.ReadLine(), out dateTime);
                if (validation== true)
                {
                    break;
                }
            }

            line = line + com + dateTime;
            Console.WriteLine("Type your Phonenumber");
            line = line + com + Console.ReadLine();                 
            return line;
        }

        
    }
}
