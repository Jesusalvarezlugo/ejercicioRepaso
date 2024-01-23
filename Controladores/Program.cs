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
            int opcionFunc;
            bool cerrarMenu = false;
            bool cerrarMenuFunc = false;

           do
            {
                mi.mostrarMensajeBienvenida();

                opcionS = mi.mostrarMenuYSeleccionEmpOCli();
                
                switch(opcionS)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se ejecutara la opcion 0");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Se ejecutara la opcion 1");

                        while (!cerrarMenuFunc)
                        {
                            opcionFunc = mi.mostrarMenuYSeleccionFunc(1);

                            switch (opcionFunc)
                            {
                                case 0:
                                    Console.WriteLine("[INFO] Se ejecutara la opcion 0");
                                    cerrarMenuFunc = true;
                                    break;

                                case 1:
                                    Console.WriteLine("[INFO] Se ejecutara la opcion 1");
                                    break;

                                case 2:
                                    break;

                                case 3:
                                    break;
                            }
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("[INFO] Se ejecutara la opcion 1");
                        while (!cerrarMenuFunc)
                        {
                            opcionFunc = mi.mostrarMenuYSeleccionFunc(0);
                            Console.WriteLine("opcion: {0}",opcionFunc); 

                            switch (opcionFunc)
                            {
                                case 0:
                                    Console.WriteLine("[INFO] Se ejecutara la opcion 0");
                                    cerrarMenuFunc = true;
                                    break;

                                case 1:
                                    Console.WriteLine("[INFO] Se ejecutara la opcion 1");
                                    oi.registrarCLiente(listaClientes);

                                    foreach(ClienteDto cliente in listaClientes)
                                    {
                                        Console.WriteLine(cliente);
                                    }
                                    break;

                                case 2:
                                    Console.WriteLine("[INFO] Se ejecutara la opcion 2");
                                    break;
                            }
                        }
                        break;
                }
            }while (!cerrarMenu) ;
        }
    }
}
