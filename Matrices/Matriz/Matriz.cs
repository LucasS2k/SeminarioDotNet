namespace ej7;

public class Matriz
{
    private double[,] _datos;
    private int _filas;
    private int _columnas;

    public Matriz(int filas, int columnas)
    {
        _filas = filas;
        _columnas = columnas;
        _datos = new double [filas, columnas];
    }

    public Matriz (double[,] matriz)
    {
        _filas = matriz.GetLength(0);
        _columnas = matriz.GetLength(1);
        _datos = matriz; //copia los datos porque apuntan al mismo lugar
    }

    public void SetElemento(int fila, int columna, double elemento)
    {
        _datos[fila, columna] = elemento;
    }

    public double GetElemento(int fila, int columna)
    {
        return _datos[fila,columna];
    }

    public void Imprimir()
    {
        for (int i = 0; i < _filas; i++)
        {
            for (int j = 0; j <_columnas; j++)
            {
                Console.Write($"{_datos[i, j]} \t");
                
            }
            Console.WriteLine();
        }
    }

    public double[] GetFila (int fila)
    {   
        double [] filaRequerida = new double [_columnas];
       for (int j = 0; j < _columnas; j++)
        {
            filaRequerida[j] = _datos[fila,j];
        } 
        return filaRequerida;
    }
}
