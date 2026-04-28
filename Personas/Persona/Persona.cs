namespace Persona
{
    public class Persona
    {
        public string? Nombre { get; set; }
        public int Documento { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int Edad
        {
            get
            {
                int edad = DateTime.Today.Year - FechaNacimiento.Year;
                if (DateTime.Today < FechaNacimiento.AddYears(edad)) edad--;
                return edad;
            }
        }

        public Persona(string? nombre, int documento, char sexo, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Documento = documento;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
        }

        public object? this[int indice]
        {
            get
            {
                return indice switch
                {
                    0 => Nombre,
                    1 => Sexo,
                    2 => Documento,
                    3 => FechaNacimiento,
                    4 => Edad,
                    _ => throw new IndexOutOfRangeException("Índice fuera de rango (0-4)")
                };
            }
            set
            {
                switch (indice)
                {
                    case 0: Nombre = value as string; break;
                    case 1: Sexo = Convert.ToChar(value!); break;
                    case 2: Documento = Convert.ToInt32(value); break;
                    case 3: FechaNacimiento = Convert.ToDateTime(value); break;
                    case 4:  break;
                    default: throw new IndexOutOfRangeException("Índice fuera de rango (0-4)");
                }
            }
        }

        public string Imprimir()
        {
            return $"Nombre: {Nombre}, Documento: {Documento}, Edad: {Edad} años, Sexo: {Sexo}, Fecha: {FechaNacimiento.ToShortDateString()}";
        }

        public bool EsMayorQue(Persona p)
        {
            return this.Edad > p.Edad;
        }
    }
}