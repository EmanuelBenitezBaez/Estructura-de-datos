
Cliente cliente = new Cliente { NombreCompleto = "John Doe", Telefono = "555-555-5555", Direccion = "123 Main St", Email = "johndoe@example.com", EsNuevoCliente = true };
cliente.MostrarDatos();

struct Cliente
{
    public string NombreCompleto;
    public string Telefono;
    public string Direccion;
    public string Email;
    public bool EsNuevoCliente;

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre completo: " + NombreCompleto);
        Console.WriteLine("Teléfono: " + Telefono);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Es nuevo cliente: " + EsNuevoCliente);
    }

}
