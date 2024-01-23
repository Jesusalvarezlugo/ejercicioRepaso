using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Bienvenido al Menú de seleccion";

            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccionEmpOCli()
        {
            int opcion;

            Console.WriteLine("####################");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Empleado");
            Console.WriteLine("2. Cliente");
            Console.WriteLine("####################");
            Console.WriteLine("Elija una opcion: ");
            opcion=Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

        public int mostrarMenuYSeleccionFunc(int controlador)
        {
            int opcion;

            

            if (controlador == 0)
            {
                Console.WriteLine("[INNFO] Menu de cliente");
                Console.WriteLine("####################");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Acceso cliente");
                Console.WriteLine("####################");
                Console.WriteLine("Elija una opcion: ");
                opcion=Console.ReadKey(true).KeyChar - ('0');
                


            }
            else 
            {
                Console.WriteLine("[INNFO] Menu de empleado");
                Console.WriteLine("####################");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Validar cliente");
                Console.WriteLine("2. Borado de cliente");
                Console.WriteLine("3. Mostrar cliente");
                Console.WriteLine("####################");
                Console.WriteLine("Elija una opcion: ");
                opcion = Console.ReadKey(true).KeyChar - ('0');
                

            }

            return opcion;

            


        }
    }
}
