namespace Figuras;
public abstract class Figura
{
    public abstract double GetArea();
}
public class Circulo : Figura
{
    private double _radio;

    public Circulo(double radio)
    {
        _radio = radio;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radio, 2);
    }
}

public class Rectangulo : Figura
{
    private double _base;
    private double _altura;

    public Rectangulo(double baseRectangulo, double altura)
    {
        _base = baseRectangulo;
        _altura = altura;
    }

    public override double GetArea()
    {
        return _base * _altura;
    }
}
