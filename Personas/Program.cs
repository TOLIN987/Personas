using Personas;


Console.WriteLine("¿Cuantos contactos desea agregar?");
int N = Int32.Parse(Console.ReadLine());
Contacto[] p = new Contacto[N];

for (int i = 0; i < N; i++)
{
    Console.Clear();
    p[i] = new Contacto();
    Console.WriteLine("Contacto {0}\nNombre", i + 1);
    p[i].Nombre = Console.ReadLine();
    Console.WriteLine("Telefono");
    p[i].Telefono = Console.ReadLine();
    p[i].FechaNacimiento = DateTime.Parse("2003/01/01");
}

Console.Clear();

for (int i = 0; i < N; i++)
{
    Console.WriteLine(p[i].ToString());
}
Console.ReadKey();