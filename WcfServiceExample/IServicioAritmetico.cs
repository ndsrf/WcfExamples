using ServicioAritmeticoDataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServicioAritmetico
    {

        [OperationContract]
        Pareja Sumar(Pareja a, Pareja b);

        [OperationContract]
        Pareja Restar(Pareja a, Pareja b);

    }


}
