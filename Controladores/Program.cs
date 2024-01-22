using ejercicioRepaso.Dtos;
using ejercicioRepaso.Servicios;

namespace ejercicioRepaso.Controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi=new OperativaImplementacion();
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            int opcionS;
            bool cerrarMenu = false;

            while(!cerrarMenu)
            {
                mi.mostrarMensajeBienvenida();

                opcionS = mi.mostrarMenuYSeleccionEmpOCli();

                switch(opcionS)
                {
                    case 0:
                        cerrarMenu = true;
                        break;

                    case 1:

                        break;

                    case 2:
                        break;
                }
            }
        }
    }
}
