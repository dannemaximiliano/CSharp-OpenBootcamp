Datos misDatos = new Datos("Maximiliano", 154568602, "Sarmiento 123", "maxi@maxi.com", true);
Console.WriteLine(misDatos.NombreCompleto);
Console.WriteLine(misDatos.Telefono);
Console.WriteLine(misDatos.Direccion);
Console.WriteLine(misDatos.Email);
Console.WriteLine(misDatos.NuevoCliente);
Console.ReadLine();
public struct Datos
{
    public Datos (string nombreCompleto, int telefono, string direccion, string email, bool nuevoCliente)
    {
        NombreCompleto = nombreCompleto;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        NuevoCliente = nuevoCliente;
    }

    public string NombreCompleto { get; }
    public int Telefono { get; }
    public string Direccion { get; }
    public string Email { get; }
    public bool NuevoCliente { get; }


    public override string ToString() => $"({NombreCompleto},{Telefono},{Direccion},{Email},{NuevoCliente})";
   
}