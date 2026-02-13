using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace MiPrimeraApp
{
    class Program
    {
        static void Main(string[] args)
        {
 
            List<string> tipo_pizza = new List<string> {"Vegetariana", "No vegetariana"};

            List<string> ingredientes = new List<string>();

            Console.WriteLine("Bienvenido a Bella Napoli, ¿Que tipo de pizza desea? \n ¿Vegetariana o No vegetariana?");
            
            string tipo = "";

            do
            {
            tipo = Console.ReadLine()!;

            if (tipo == tipo_pizza[0])
            {
                ingredientes.Add("Pimientos");
                ingredientes.Add("Tofu");
                ingredientes.Add("");
                Console.WriteLine("Los ingredientes adicionales para elegir son: ");
                foreach (string ingrediente in ingredientes)
            {
                Console.WriteLine(ingrediente);
                if (ingrediente == "Tofu") break;
            }
            }
            else if (tipo == tipo_pizza[1])
            {
                ingredientes.Add("Pepperoni");
                ingredientes.Add("Jamon");
                ingredientes.Add("Salmon");
                Console.WriteLine("Los ingredientes adicionales para elegir son: ");
                foreach (string ingrediente in ingredientes)
            {
                Console.WriteLine(ingrediente);
            }
            }    
            else
                {
                    Console.WriteLine("Escriba bien por favor");
                }
            } while (tipo != tipo_pizza[0] && tipo != tipo_pizza[1]);

            string adicional = "";
            string seleccion = "";

            do
            {
            adicional = Console.ReadLine()!;

            if (adicional == ingredientes[0])
            {
                seleccion = adicional;
            }
            else if (adicional == ingredientes[1])
            {
                seleccion = adicional;
            }
            else if (adicional == ingredientes[2])
            {
                seleccion = adicional;
            }
            else
            {
                Console.WriteLine("Escriba bien por favor");
            }
            } while (adicional != ingredientes[0] && adicional != ingredientes[1] && adicional != ingredientes[2]);

            ingredientes.Clear();
            ingredientes.Add(seleccion);
            ingredientes.Add("Mozzarella");
            ingredientes.Add("Tomate");
            ingredientes.Reverse();

            Console.WriteLine($"Muchas gracias, su orden es una pizza {tipo} con los siguientes ingredientes: ");

            foreach (string ingrediente in ingredientes)
            {
                Console.WriteLine($"//{ingrediente}//");
            }

        }
    }
}