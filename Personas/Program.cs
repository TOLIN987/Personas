using Personas;

    Contacto p = new Contacto();
    string line = p.Obtain_Data();
    string[]  data;
    data = line.Split(',');
    p.Nombre = data[0];
    p.FechaNacimiento = DateTime.Parse(data[1]);
    p.Telefono = data[2];
    Console.Clear();
    Console.ReadKey();