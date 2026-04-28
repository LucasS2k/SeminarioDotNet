namespace Cuentas;

public class Cuenta
{ private static List<Cuenta> _todasLasCuentas = new List<Cuenta>();
    private static int _contadorCuentas = 0;
    private static int _cantidadDepositos = 0;
    private static double _totalDepositado = 0;
    private static int _cantidadExtracciones = 0;
    private static double _totalExtraido = 0;

    private int _id;
    private double _saldo;
    public Cuenta()
    {
        _contadorCuentas++;
        _id = _contadorCuentas;
        _saldo = 0;
        _todasLasCuentas.Add(this);
        Console.WriteLine($"Se creó la cuenta Id={_id}");
    }
    public Cuenta Depositar (double monto)
    {
        _saldo += monto;
        _cantidadDepositos ++;
        _totalDepositado += monto;
        Console.WriteLine($"se deposito {monto} en la cuenta {_id} saldo: {_saldo}");
        return this;
    }

    public Cuenta Extraer (double monto)
    {
        if (_saldo > monto) {
            _saldo -= monto;
            Console.WriteLine($"Se extrajo {monto} saldo: {_saldo}");
        }
        else
        {
           Console.WriteLine("Operación denegada - Saldo insuficiente");
        }
        return this;
    }
    public static void ImprimirDetalle()
    {
        Console.WriteLine($"CUENTAS CREADAS: {_contadorCuentas}");
        Console.WriteLine($"DEPÓSITOS: {_cantidadDepositos} - Total depositado: {_totalDepositado}");
        Console.WriteLine($"EXTRACCIONES: {_cantidadExtracciones} - Total extraído: {_totalExtraido}");
        Console.WriteLine($"- Saldo {_totalDepositado - _totalExtraido}");
    }
    public static IReadOnlyList<Cuenta> GetCuentas()
{
    return _todasLasCuentas.AsReadOnly();
}
}
   