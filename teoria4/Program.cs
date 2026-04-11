// 8 Prestar atención a los siguientes programas (ninguno funciona correctamente):
// Foo f = new Foo();
// f.Imprimir();
// class Foo
// {
// string? _bar;
// public void Imprimir()
// {
// Console.WriteLine(_bar.Length); //no se ha inicializazo, tira un null reference
// }
// }

// Foo f = new Foo();
// f.Imprimir();
// class Foo
// {
// public void Imprimir()
// {
// string? bar;
// Console.WriteLine(bar.Length); //intenta medir el largo de una variable que puede ser null, idem anterior
// }
// }
//¿Qué se puede decir acerca de la inicialización de los objetos? ¿En qué casos son inicializados
//automáticamente y con qué valor?
//Rta: las variables de instancia de una clase o los arrays son inicializados automaticamente
// los valores por referencia se inicializan con con null

//9 ¿Qué se puede decir en relación a la sobrecarga de métodos en este ejemplo?
// class A
// {
//     public void Metodo(short n)
//     {
//         Console.WriteLine("short {0} -", n);
//     }

//     public void Metodo(int n)
//     {
//         Console.WriteLine("int {0} -", n);
//     }

//     public int Metodo(int n)
//     {
//         return n + 10;
//     }
// }
// Rta: para poder hacer la sobrecarga deben tener diferente cantidad o tipo de parametros

//10 

//11 Reemplazar estas líneas de código por otras equivalentes que utilicen el operador null-coalescing (?? ) y / o la asignación null-coalescing (??=)
    // if (st1 == null)
    // {
    //      if (st2 == null)
    //     {
    //      st = st3;
    //     }
    // else
    // {
    //      st = st2;
    // }
    //     }
    //      else
    //      {
    //          st = st1;
    //  }
    // if (st4 == null)
    // {
    // st4 = "valor por defecto";
    // }
    //  Rta:
    // st = st1 ?? st3 ?? st2;
    // st4 ??= "valor por defecto";

