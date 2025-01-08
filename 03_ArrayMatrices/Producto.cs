using System;

public class Producto
{
    // Propiedades privadas del producto
    private int id;
    private string nombre;
    private string unidad;
    private decimal[] precios;

    // Constructor que inicializa las propiedades del producto
    public Producto(int id, string nombre, string unidad, decimal precioPromocional, decimal precioNormal, decimal precioMayorista)
    {
        this.id = id;
        this.nombre = nombre;
        this.unidad = unidad;
        this.precios = new decimal[] { precioPromocional, precioNormal, precioMayorista };
    }

    // Métodos públicos para obtener los valores de las propiedades privadas
    public int GetId() => id;
    public string GetNombre() => nombre;
    public string GetUnidad() => unidad;
    public decimal[] GetPrecios() => precios;

    // Método para mostrar los detalles del producto
    public void MostrarProducto()
    {
        // Mostrar la información del producto formateada
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Unidad: {unidad}");
        Console.WriteLine($"Precio Promocional: ${precios[0]:0.00}, Precio Normal: ${precios[1]:0.00}, Precio Mayorista: ${precios[2]:0.00}");
    }
}