using System;
//Console.WriteLine("Hello, World!");
// ej 1
//Console.Write("hola");
//bool pressedKey = Console.ReadKey().Key == ConsoleKey.Enter;
//if (pressedKey)
//{
//    Console.WriteLine("mundo");
//}
// ej 2
//string texto = "prueba \n prueba \t prueba \" prueba \\ prueba ";
//Console.Write(texto);  
//ej 3
//string st = "c:\\ Windows\\system";
//Console.WriteLine(st);
// ej 4
//
//Console.WriteLine("Ingrese su nombre");
//string? nombre = Console.ReadLine();
//if (string.IsNullOrEmpty(nombre))
//{
//    Console.WriteLine("Hola mundo");
//} else
//{
//    Console.WriteLine("hola" + nombre);
//}
// ej 5
//Console.WriteLine("Ingrese un nombre");
//string? nombre2 = Console.ReadLine();
//
//switch (nombre2)
//{
//    case "Maria":
//        Console.WriteLine("Hola, Maria");
//        break;
//    case "Pepe":
//        Console.WriteLine("Hola, Pepe");
//        break;
//    default:
//        Console.WriteLine("Nombre no reconocido");
//        break;
//}
// ej 6
//string? stringIngresado = Console.ReadLine();
//while (stringIngresado != "")
//{
//    Console.WriteLine(stringIngresado.Length);
//    stringIngresado = Console.ReadLine();
//}

//ej 7
// 7) Qué hace la instrucción Console.WriteLine("100".Length); ?
// rta: imprime 3, la cantidad de caracteres que tiene la cadena "100"

// Ej 8
// 8) Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:
//Console.WriteLine(st=Console.ReadLine());?
//string? st;
//Console.WriteLine(st=Console.ReadLine());
// rta: es válida, se asigna el valor ingresado a la variable st y luego se imprime ese valor en la consola

// Ej 9 
// Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>, y
//determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).
//Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]
//devuelve el último carácter de st.
//string? palabras = Console.ReadLine();
//string[] palabrasSeparadas = palabras.Split(' ');
//string palabra1 = palabrasSeparadas[0];
//string palabra2 = palabrasSeparadas[1];
//bool sonSimetricas = true;
//if (palabra1.Length != palabra2.Length)
//{
//    sonSimetricas = false;
//}
//else
//{
//    for (int i = 0; i < palabra1.Length; i++)
//    {
//        if (palabra1[i] != palabra2[palabra2.Length - 1 - i])
//        {
//            sonSimetricas = false;
//            break;
//        }
//    }
//}
//Console.WriteLine(sonSimetricas ? "Simétricas" : "No simétricas");

// ej 10
// bool puedo = true;
// bool puedo2 = true;
// int multi = 1;
// while (puedo | puedo2)
// {
//     if (multi * 17 < 1000) {
//         Console.WriteLine(multi * 17);
//     } else {
//         puedo = false;
//     }
//     if (multi * 29 < 1000) {
//         Console.WriteLine(multi * 29);
//     } else {
//         puedo2 = false;
//     }
//     multi ++;
// } 

//ej 11
// Console.WriteLine("10/3 = " + 10 / 3);
// Console.WriteLine("10.0/3 = " + 10.0 / 3);
// Console.WriteLine("10/3.0 = " + 10 / 3.0);
// int a = 10, b = 3;
// Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
// Console.WriteLine("entonces a/b = " + a / b);
// double c = 3;
// Console.WriteLine("Si c es una variable double, c=3");
// Console.WriteLine("entonces a/c = " + a / c);
// a) ¿Qué se puede concluir respecto del operador de división “/” ?
// realiza un division entera a menos que uno de los operandos sea un número con decimales
// b) ¿Cómo funciona el operador + entre un string y un dato numérico?
// convierte el dato numérico a string y luego concatena ambos strings

// ej 12
//12) Escribir un programa que imprima todos los divisores de un número entero ingresado desde consola. Para obtener el entero desde un string st utilizar int.Parse(st).
// Console.WriteLine("Ingrese un número entero:");
// string? input = Console.ReadLine();
// if (int.TryParse(input, out int numero))
// {
//     Console.WriteLine($"Los divisores de {numero} son:");
//     for (int i = 1; i <= numero; i++)
//     {
//         if (numero % i == 0)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }
// else
// {
//     Console.WriteLine("Ingrese un numero entero");
// }

// ej 13
// Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente
//expresión. Tip: observar qué pasa cuando b = 0.
//if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);
// ocurriria una division por cero 
// para resolverlo se puede usar el operador && en lugar de & para que la segunda parte de la condicion no se evalue si b es 0

// ej 14
// Utilizar el operador ternario condicional para establecer el contenido de una variable entera con el menor valor de otras dos variables enteras.
//int x = 1;
//int y = 5; 
//int menor = (x < y) ? x : y;
//Console.WriteLine("El menor valor es: " + menor);

// ej 15
// 15) ¿Cuál es el problema del código siguiente y cómo se soluciona?
//int i = 0;
//for (int i = 1; i <= 10;)
//{
//Console.WriteLine(i++);
//}
// i es declarada fuera del for, se soluciona borrando esa linea

// ej 16
//Analizar el siguiente código. ¿Cuál es la salida por consola?
int i = 1;
if (--i == 0)
{
Console.WriteLine("cero");
}
if (i++ == 0)
{
Console.WriteLine("cero");
}
Console.WriteLine(i);
// imprime cero, cero, 1