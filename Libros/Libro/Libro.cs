namespace practica5;

public class Libro
{
    private readonly int _isbn;
    private string _titulo;
    private double _precio;
    private DateTime _fechaPublicacion;
    public required string Titulo { get ;init;}

    public double Precio{get;set;}

    public DateTime FechaPublicacion{get;init;}
    public Libro(int isbn, string titulo, double precio, DateTime fechaPublicacion)
    {
        _isbn = isbn;
        _titulo = titulo;
        _precio = precio;
        _fechaPublicacion = fechaPublicacion;
    }
}
