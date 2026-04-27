using practica5;
// Caso A:
Libro libro1 = new Libro();
// Caso B:
Libro libro2 = new Libro
{
Titulo = "C# Moderno",
FechaPublicacion = new DateTime(2026, 1, 1),
Precio = 4500.0,
ISBN = "978-3-16-148410-0"
};
// Caso C:
Libro libro3 = new Libro("978-3-16-148410-0") {Titulo="C# Moderno"};
libro3.Precio=4500.0;
// Caso D:
libro3.ISBN = "978-3-16-148410-9";
libro3.FechaPublicacion = DateTime.Now;
libro3.Titulo=".NET Moderno";
