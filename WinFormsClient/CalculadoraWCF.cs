using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioAritmeticoDataContracts;

namespace WinFormsClient
{
    class CalculadoraWCF : ICalculadora 
    {

        MiServicioAritmetico.ServicioAritmeticoClient client;

        public CalculadoraWCF()
        {
            client = new MiServicioAritmetico.ServicioAritmeticoClient();
        }

        public Pareja Sumar(Pareja a, Pareja b)
        {
            return client.Sumar(a, b);
        }

        public Pareja Restar(Pareja a, Pareja b)
        {
            return client.Restar(a, b);
        }
    }
}
