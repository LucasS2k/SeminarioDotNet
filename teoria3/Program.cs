// 1 Comprobar tipeando teclas y modificadores (shift, ctrl, alt) para apreciar de qué manera se
//puede acceder a esta información en el código del programa.
// Console.CursorVisible = false;
// ConsoleKeyInfo k = Console.ReadKey(true);
// while (k.Key != ConsoleKey.End)
// {
// Console.Clear();
// Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
// k = Console.ReadKey(true);
// }
// Rta: imprime el modificador, la tecla y su char

//2 Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo de dos
//dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en la misma línea
//en la consola.
// double[,] matriz = new double [3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
// void ImprimirMatriz(double[,] matriz)
// {
//     for (int i = 0; i< matriz.GetLength(0); i++)
//     {
//         for (int x = 0; x < matriz.GetLength(0); x++)
//         {
//             Console.WriteLine(matriz[i,x]);
//         }
//     }
// }
// ImprimirMatriz(matriz);

//3 Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora con un
// parámetro más que representa la plantilla de formato que debe aplicarse a los números al imprimirse.
// La plantilla de formato es un string de acuerdo a las convenciones de formato compuesto, por ejemplo
// “0.0” implica escribir los valores reales con un dígito para la parte decimal.

// void ImprimirMatrizConFormato(double[,] matriz, string formato)
// {
//     for (int i = 0; i < matriz.GetLength(0); i++)
//     {
//         for ( int x = 0; x < matriz.GetLength(0); x++)
//         {
//             Console.Write($"{matriz[i,x].ToString(formato)}\t");
//         }
//     }
// }
// ImprimirMatrizConFormato(matriz, "0.0");

//4 Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que devuelven
// un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la matriz no es
// cuadrada generar una excepción ArgumentException.

// double [] getDiagonalPrincipal(double[,] matriz)
// {
//     int filas = matriz.GetLength(0);
//     int columnas = matriz.GetLength(1);
//     if (filas != columnas)
//     {
//         throw new ArgumentException("La matriz debe ser cuadrada");
//     }
//     double [] diagonal = new double[filas];
//     for (int i = 0; i< matriz.GetLength(0); i++)
//     {
//         diagonal[i] = matriz[i,i];
//     }
//     return diagonal;
// }

// double[] getDiagonalSecundaria(double[,] matriz)
// {
//     int filas = matriz.GetLength(0);
//     int columnas = matriz.GetLength(1);
//     if (filas != columnas)
//     {
//         throw new ArgumentException("La matriz debe ser cuadrada");
//     }
//     double [] diagonal = new double[filas];
//     for (int i = 0; i < matriz.GetLength(0); i++)
//     {
//         diagonal[i]= matriz[i, filas -i];
//     }
//     return diagonal;
// }

// 5 Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la matriz
// pasada como parámetro:

// double[][] GetArregloDeArreglo(double [,] matriz)
// {
//     int filas = matriz.GetLength(0);
//     int columnas = matriz.GetLength(1);

//     double [][]arrayDeArrays = new double [filas][];
//     for (int i = 0 ; i < filas; i++)
//     {
//         arrayDeArrays[i] = new double [columnas];
//         for (int x =0; x< columnas; x++)
//         {
//             arrayDeArrays[i][x] = matriz [i,x];
//         }

//     }
//     return arrayDeArrays;
// }

//6 Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices
// pasadas como parámetros. Para el caso de la suma y la resta, las matrices deben ser del mismo tamaño,
// en caso de no serlo devolver null. Para el caso de la multiplicación la cantidad de columnas de A debe
// ser igual a la cantidad de filas de B, en caso contrario generar una excepción ArgumentException.


// double[,]? Suma(double[,] A, double[,] B)
// {
//     int filasA = A.GetLength(0);
//     int filasB = B.GetLength(0);
//     int columnasA = A.GetLength(1);
//     int columnasB = B.GetLength(1);
//     if (filasA == filasB && columnasA == columnasB)
//     {
//         double[,] suma = new double[filasA,columnasA];
//         for (int i = 0; i < filasA; i++)
//         {
//             for (int x =0; x < columnasA; x++)
//             {
//                 suma[i,x] = A[i,x] + B[i,x];
//             }
//         }
//         return suma;
//     }
//     else
//     {
//         throw new ArgumentException("las matrices son diferentes");
//     }
// }

// double[,]? Resta(double[,] A, double[,] B)
// {
//     int filasA = A.GetLength(0);
//     int filasB = B.GetLength(0);
//     int columnasA = A.GetLength(1);
//     int columnasB = B.GetLength(1);
//     if (filasA == filasB && columnasA == columnasB)
//     {
//         double[,] resta = new double[filasA,columnasA];
//         for (int i = 0; i < filasA; i++)
//         {
//             for (int x =0; x < columnasA; x++)
//             {
//                 resta[i,x] = A[i,x] - B[i,x];
//             }
//         }
//         return resta;
//     }
//     else
//     {
//         throw new ArgumentException("las matrices son diferentes");
//     }
// }

// double[,]? Multiplicacion(double[,] A, double[,] B)
// {
//     int filasA = A.GetLength(0);
//     int filasB = B.GetLength(0);
//     int columnasA = A.GetLength(1);
//     int columnasB = B.GetLength(1);
//     if (filasA ==  columnasB && filasB == columnasA)
//     {
//         double[,] multi = new double[filasA,columnasA];
//         for (int i = 0; i < filasA; i++)
//         {
//             for (int x =0; x < columnasA; x++)
//             {
//                 multi[i,x] = A[i,x] * B[i,x];
//             }
//         }
//         return multi;
//     }
//     else
//     {
//         throw new ArgumentException("las matrices son diferentes");
//     }
// }

//7 ¿De qué tipo quedan definidas las variables x, y, z en el siguiente código?
// int i = 10;
// var x = i * 1.0;
// var y = 1f;
// var z = i * y;
// Rta: x es double, y es float y z es float

//8 Señalar errores de compilación y/o ejecución en el siguiente código:
//object obj = new int[10];
//dynamic dyna = 13;
//Console.WriteLine(obj.Length); // los objetos no tienen esa propiedad
//Console.WriteLine(dyna.Length); // int tampoco tiene esa propiedad y da error en ejecucion

//9 ¿Qué líneas del siguiente método provocan error de compilación y por qué?
// var a = 3L; // sin problemas
// dynamic b = 32; // sin problemas
// object obj = 3; // sin problemas
// a = a * 2.0; // A es long y 2.0 es double, no se pueden multiplicar
// b = b * 2.0; //B es dynamic, se resuelve en ejecucion sin errores
// b = "hola"; // B es dynamic, se resuelve en ejecucion sin errores   
// obj = b; // obj es object y b es dynamic, no se pueden asignar entre si
// b = b + 11; // B es dynamic, se resuelve en ejecucion sin errores, se convierte a string y concatena 11
// obj = obj + 11; // no se puede sumar un objeto con un numero
// var c = new { Nombre = "Juan" }; 
// var d = new { Nombre = "María" }; 
// var e = new { Nombre = "Maria", Edad = 20 }; 
// var f = new { Edad = 20, Nombre = "Maria" };
// f.Edad = 22; // no se pueden modificar las propiedades de un objeto anonimo
// d = c; //es posible porque tienen la misma estructura
// e = d; // no es posible porque e tiene una propiedad mas que d
// f = e; // no es posible porque tienen un orden diferente

//10 Verificar con un par de ejemplos si la sección opcional [:formatString] de formatos
// compuestos redondea o trunca cuando se formatean números reales restringiendo la cantidad de
// decimales. Plantear los ejemplos con cadenas de formato compuesto y con cadenas interpoladas.
// Console.WriteLine("{0:0.0}", 3.1416); // redondea a 3.1
// Console.WriteLine($"{3.1416:0.0}"); // redondea a 3.1
// formatString redondea a 3.1, no trunca

//11 Señalar errores de ejecución en el siguiente código:
// List<int> a = [ 1, 2, 3, 4 ]; 
// a.Remove(5); // el 5 no existe en esta lista
// a.RemoveAt(4); //la posicion 4 no existe tampoco, va de 0 a 3

//12 Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están
// bien balanceados. Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena de
// entrada. Utilizar una pila para resolverlo. Los paréntesis de apertura de la entrada se almacenan en una
// pila hasta encontrar uno de cierre, realizándose entonces la extracción del último paréntesis de apertura
// almacenado. Si durante el proceso se lee un paréntesis de cierre y la pila está vacía, entonces la cadena
// es incorrecta. Al finalizar el análisis, la pila debe quedar vacía para que la cadena leída sea aceptada, de
// lo contrario la misma no es válida.

//  bool ParentesisBalanceados(string A)
// {
//     Stack<char> pila = new Stack<char>();
//     foreach (char C in A)
//     {
//         if (C =='(')
//         {
//             pila.Push(C);
//         }
//         else if (C == ')')
//         {
//             if (pila.Count == 0)
//             {
//                 return false;
//             }
//             pila.Pop();
//         }
//     }
//     return pila.Count == 0;
// }


//13 Utilizar la clase Stack<T> (pila) para implementar un programa
// que pase un número en base 10 a otra base realizando divisiones
// sucesivas. Por ejemplo para pasar 35 en base 10 a binario dividimos
// sucesivamente por dos hasta encontrar un cociente menor que el
// divisor, luego el resultado se obtiene leyendo de abajo hacia arriba el
// cociente de la última división seguida por todos los restos.

// string pasarABinario (int N)
// {
//     Stack<int> pila = new Stack<int>();
//     if (N == 0)
//     {
//         return "0";
//     }
//     while (N > 0)
//     {
//         pila.Push(N % 2);
//         N = N / 2;
//     }
//     string resultado = "";
//     while (pila.Count > 0)
//     {
//         resultado += pila.Pop().ToString();
//     }
//     return resultado;
// }

//14 Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto
// aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un carácter
// una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave. Por ejemplo: para
// la siguiente tabla de caracteres:
//A B C D E F G H I J K L M N Ñ O P Q R S T U V W X Y Z sp
// 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28
// public class Cifrado
// {
//     private static readonly char[] caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZÑ ".ToCharArray();
//     public static string Cifrar(string texto, int[] clave)
//     {
//         Queue<int> cola = new Queue<int>(clave);
//         string resultado = "";
//         foreach (char c in texto)
//         {
//             int indice = Array.IndexOf(caracteres, c);
//             if (indice == -1)
//             {
//                 resultado += c; // si el caracter no está en la tabla, se deja igual
//             }
//             else
//             {
//                 int desplazamiento = cola.Dequeue();
//                 int nuevoIndice = (indice + desplazamiento) % caracteres.Length;
//                 resultado += caracteres[nuevoIndice];
//                 cola.Enqueue(desplazamiento); // se vuelve a agregar el desplazamiento al final de la cola
//             }
//         }
//         return resultado;
//     }
// }

// 15 Contar Frecuencia de Palabras en Texto.
// a) Crear un método ContarFrecuenciaPalabras que reciba una cadena de texto y devuelva un
// diccionario con el conteo de cada palabra.
// b) El conteo debe ser insensible a mayúsculas/minúsculas (tratar "Hola" y "hola" como iguales).
// c) Dentro del método, procesar el texto para separar las palabras. Considerar usar texto.Split()
// separando por espacios y signos de puntuación comunes.
// d) Utilizar y devolver un Dictionary<string, int> donde la clave es la palabra y el valor su
// frecuencia.
// e) Probar el método: Llamarlo con un texto de ejemplo y mostrar en consola cada palabra y su
// frecuencia del diccionario resultante.
// Ejemplo de Salida Esperada (para "Hola, hola. Me escuchan? o no me escuchan?"):

// static Dictionary<string, int> ContarFrecuenciaPalabras(string texto)
// {
//     Dictionary<String, int> frecuencia = new Dictionary<string,int>();
//     string [] palabras = texto.ToLower().Split(" ");
//     foreach (string palabra in palabras){
//         if (frecuencia.ContainsKey(palabra))
//         {
//             frecuencia[palabra]++;
//         }
//         else
//         {
//             frecuencia[palabra] = 1;
//         }
        
//     }
//     return frecuencia;
// }

//16 ¿Qué salida por la consola produce el siguiente código?
// int x = 0;
// try
// {
// Console.WriteLine(1.0 / x);
// Console.WriteLine(1 / x);
// Console.WriteLine("todo OK");
// }
// catch (Exception e)
// {
// Console.WriteLine(e.Message);
// }
// Rta attempted to divide by zero

//17 Implementar un programa que permita al usuario ingresar números por la consola. Debe ingresarse
// un número por línea finalizado el proceso cuando el usuario ingresa una línea vacía. A medida que se
// van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos.
// Utilizar double.Parse() y try/catch para validar que la entrada ingresada sea un número válido,
// en caso contrario advertir con un mensaje al usuario y proseguir con el ingreso de datos.
// double suma = 0;
// string input;
// Console.WriteLine("Ingrese un número (deje vacio para finalizar): ");
// while((input = Console.ReadLine() ?? "") != "")
// {
//     try
//     {
//         double numero = double.Parse(input);
//         suma += numero;
//         Console.WriteLine($"Suma acumulada: {suma}");
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Entrada no valida, programa finalizado");
//     }
// }

//18 Cuál es la salida por consola del siguiente programa:

try
{
Metodo1();
}
catch
{
Console.WriteLine("Método 1 propagó una excepción no tratada");
}
try
{
Metodo2();
}
catch
{
Console.WriteLine("Método 2 propagó una excepción no tratada");
}
try
{
Metodo3();
}
catch
{
Console.WriteLine("Método 3 propagó una excepción");
}

void Metodo1()
{
object obj = "hola"
;

try
{
int

i = (int
)obj
;

}
finally
{
Console

.WriteLine

("Bloque finally en Metodo1");

}
}
void Metodo2()
{
object obj = "hola"
;

try
{
int

i = (int
)obj
;

}
catch (OverflowException
)

{
Console

.WriteLine

("Overflow");

}
}

void Metodo3()
{
object obj = "hola";
try
{
int i = (int)obj;
}
catch (InvalidCastException)
{
Console.WriteLine("Excepción InvalidCast en Metodo3");
throw;
}
}

//Bloque finally en Metodo1
// Método 1 propagó una excepción no tratada
// Método 2 propagó una excepción no tratada
// Excepción InvalidCast en Metodo3
// Método 3 propagó una excepción