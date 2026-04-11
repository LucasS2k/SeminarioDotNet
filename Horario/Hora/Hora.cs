namespace ej4;

public class Hora
{
    private int _horas;
    private int _minutos;

    private int _segundos;

    public Hora(int horas, int minutos, int segundos)
    {
        _horas = horas;
        _minutos = minutos;
        _segundos = segundos;
    }

    public String Imprimir()
    {
        return $"Horas: {_horas} Minutos: {_minutos} Segundos: {_segundos}";
    }
}

