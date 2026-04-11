namespace Automotores;

public class Auto
{
    private string? _marca;
    private int _modelo;

    public Auto(string marca, int modelo = 2022) //si no se sobreescribe el valor por default es 2022
    {
        _marca = marca;
        _modelo = modelo;
    }

    public string GetDescripcion()
    {
        return $"Auto {_marca} {_modelo}";
    }
}
