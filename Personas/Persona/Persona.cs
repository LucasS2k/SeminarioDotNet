namespace Persona
{
    public class Persona
    {
        private string? _Nombre ;
        private int _Documento ;
        private int _Edad ;
        public Persona(string? nombre, int documento, int edad)
        {
            _Nombre = nombre;
            _Documento = documento;
            _Edad = edad;
        }
        public string Imprimir()
        {
            return $"Nombre: {_Nombre}, Documento: {_Documento}, Edad: {_Edad}";
        }

        public Boolean EsMayorQue(Persona p)
        {
            return this._Edad > p._Edad;
        }
    }
    
    
}