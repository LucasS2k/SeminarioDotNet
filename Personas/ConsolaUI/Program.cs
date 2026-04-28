namespace ConsolaUI
{    using System;
    using System.Collections.Generic;
    using Persona;
class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();
            string? input;
            Console.WriteLine("ingrese: 'nombre documento edad' ");
            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                try
                {
                    string[] slices = input.Split(',');
                    if (slices.Length == 5)
                    { string nombre = slices[0].Trim();
                        int documento = int.Parse(slices[1].Trim());
                        int sexoInt = int.Parse(slices[2].Trim());
                        DateTime nacimiento = DateTime.Parse(slices[3].Trim());
                        char sexo = (char)sexoInt;
                        Persona persona = new Persona(nombre, documento, sexo, nacimiento);
                       
                        listaPersonas.Add(persona);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al ingresar los datos. Intente nuevamente");
                }
            }
            Console.WriteLine("Usuarios: ");
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaPersonas[i].Imprimir()}");
            }
        }
        
        public static Persona? PersonaMasJoven(List<Persona> personas)
        {
            if (personas == null || personas.Count == 0) return null;
            Persona masJoven = personas[0];
            foreach(Persona persona in personas)
            {
                if (masJoven.EsMayorQue(persona))
                {
                         masJoven = persona;
                }
               
            }
            return masJoven;    
        }
        public List<string> this[char inicial]
        {
            get
            {
                List<string> nombresFiltrados = new List<string>();
                // Pasamos la inicial a mayúscula para que no importe si envían 'l' o 'L'
                char inicialMayus = char.ToUpper(inicial);

                foreach (Persona p in _personas)
                {
                    if (p.Nombre != null && p.Nombre.Length > 0)
                    {
                        if (char.ToUpper(p.Nombre[0]) == inicialMayus)
                        {
                            nombresFiltrados.Add(p.Nombre);
                        }
                    }
                }
                return nombresFiltrados;
            }
        }
    }
    }
    }