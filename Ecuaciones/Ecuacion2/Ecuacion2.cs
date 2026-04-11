namespace Ecuacion2;

public class Ecuacion
{
    private double _a;
    private double _b;
    private double _c;

    public Ecuacion(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public double GetDiscriminante()
    {//math pow eleva el primer numero a la potencia del segundo numero
        return Math.Pow(_b,2) -4 * _a * _c; //el discriminante tiene la siguiente formula: (b^2)-4*a*c.
    }

    public int GetCantidadDeRaices()
    {
        double discriminante = GetDiscriminante();
        if (discriminante > 0)
        {
            return 2;
        }
        else if (discriminante == 0)
        {
            return 1;
        }
        else //si es menor a 0 no tiene discriminantes
        {
            return 0;
        }
    }

    public string ImprimirRaices()
    {   double D = GetDiscriminante();
        int cantidadDeRaices = GetCantidadDeRaices();
        if (cantidadDeRaices == 2)
        {
            double x = (-_b + Math.Sqrt(D)) / (2*_a); //bhaskara
            double y = (-_b - Math.Sqrt(D)) / (2*_a);
            return $"Dos raices: {x} y {y}";
        }
        else if (cantidadDeRaices == 1)
        {
            double z = -_b / (2*_a);
            return $"Unica raiz: {z}";
        }
        else return "No posee soluciones reales";
    }
}
