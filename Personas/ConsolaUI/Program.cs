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
                    if (slices.Length == 3)
                    { string nombre = slices[0].Trim();
                        int documento = int.Parse(slices[1].Trim());
                        int edad = int.Parse(slices[2].Trim());
                        Persona persona = new Persona(nombre, documento, edad);
                       
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
    }
    }