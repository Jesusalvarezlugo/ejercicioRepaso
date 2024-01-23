using ejercicioRepaso.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        

        public void registrarCLiente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente =  nuevoCliente();

            listaAntigua.Add(cliente);
            cliente.IdCliente = calcularNuevoId(listaAntigua);
        }

        private ClienteDto nuevoCliente()
        {
            ClienteDto cliente1 = new ClienteDto();

            Console.WriteLine("Introduzca su DNI: ");
            cliente1.DniCliente = Console.ReadLine();
            Console.WriteLine("Introduzca su nombre completo: ");
            cliente1.NombreCompletoCliente = Console.ReadLine();
            string[] nombrePorPartes = cliente1.NombreCompletoCliente.Split(" ");
            cliente1.NombreCliente = nombrePorPartes[0];
            cliente1.Apellido1Cliente = nombrePorPartes[1];
            cliente1.Apellido2Cliente = nombrePorPartes[2];
            cliente1.IdCliente = 1;

            return cliente1;
        }

        private long incrementoId(List<ClienteDto> listaAntigua)
        {

            //ERRONEO
            ClienteDto cliente1 = new ClienteDto();
            for (int i=0;i<listaAntigua.Count;i++)
            {
                cliente1.IdCliente += 1;
            }

            return cliente1.IdCliente;
        }

        private long calcularNuevoId(List<ClienteDto> listaAntigua)
        {
            long idCalculado;
            int tamanioLista = listaAntigua.Count;

            if (tamanioLista == 0)
            {
                idCalculado = 1;
            }
            else
            {
                idCalculado = listaAntigua[tamanioLista - 1].IdCliente + 1;
            }

            return idCalculado; 
        }

      
    }
}
