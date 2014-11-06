using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioAritmeticoDataContracts;

namespace WinFormsClient
{
    interface ICalculadora
    {
        Pareja Sumar(Pareja a, Pareja b);
        Pareja Restar(Pareja a, Pareja b);
    }
}
