using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Dtos
{
    internal class ClienteDto
    {

        //Atributos

        long idCliente;
        string dniCliente="aaaaa";
        string nombreCliente="aaaaa";
        string apellido1Cliente = "aaaaa";
        string apellido2Cliente="aaaaa";
        string nombreCompletoCliente = "aaaaa";
        string emailCliente = "aaaaa";
        string contraseniaCliente = "aaaaa";
        bool esValido = false;

       

        //Getters y Setters

        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1Cliente; set => apellido1Cliente = value; }
        public string Apellido2Cliente { get => apellido2Cliente; set => apellido2Cliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string ContraseniaCliente { get => contraseniaCliente; set => contraseniaCliente = value; }
        public bool EsValido { get => esValido; set => esValido = value; }

        //Constructores


        public ClienteDto()
        {

        }
        public ClienteDto(long idCliente, string dni, string nombreCliente, string apellido1Cliente, string apellido2Cliente, string nombreCompletoCliente, string emailCliente, string contraseniaCliente, bool esValido)
        {
            this.idCliente = idCliente;
            this.dniCliente = dni;
            this.nombreCliente = nombreCliente;
            this.apellido1Cliente = apellido1Cliente;
            this.apellido2Cliente = apellido2Cliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.emailCliente = emailCliente;
            this.contraseniaCliente = contraseniaCliente;
            this.esValido = esValido;
        }

        //Metodo toString

        override
        public string ToString()
        {
            string texto = "DNI: "+this.dniCliente+"\n NOMBRE: "+this.apellido1Cliente+" "+this.apellido2Cliente+" "+this.nombreCliente;

            return texto;
        }
        


    }
}
