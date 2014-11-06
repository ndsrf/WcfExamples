using ServicioAritmeticoDataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceExample
{
    [ServiceContract]
    public interface IServicioAritmeticoREST
    {
        [OperationContract]
        [System.ServiceModel.Web.WebInvoke(Method="GET", 
            ResponseFormat=System.ServiceModel.Web.WebMessageFormat.Xml, 
            BodyStyle=System.ServiceModel.Web.WebMessageBodyStyle.Wrapped,
            UriTemplate="sumarXml/{a}/{b}/{c}/{d}")]
        Pareja Sumar(string a, string b, string c, string d);

        [OperationContract]
        [System.ServiceModel.Web.WebInvoke(Method = "GET",
            ResponseFormat = System.ServiceModel.Web.WebMessageFormat.Json,
            BodyStyle = System.ServiceModel.Web.WebMessageBodyStyle.Bare,
            UriTemplate = "restarJson/{a}/{b}/{c}/{d}")]
        //[return: MessageParameter(Name = "ResultadoRestar")]
        Pareja Restar(string a, string b, string c, string d);

        [OperationContract]
        [System.ServiceModel.Web.WebInvoke(Method = "POST",
            UriTemplate = "SumarPost")]
        Pareja SumarPost(ParPareja p);
        /* Este POST de arriba se puede invocar desde Fiddler haciendo lo siguiente:
         * 
         * POST a http://localhost:1356/ServicioAritmeticoREST.svc/SumarPost
         * 
         * Header:
         * Accept: application/json
          Content-Type: application/json
         * 
         * Request body:
         * {"A":{"First":1,"Second":2},"B":{"First":10,"Second":20}}
         * 
         * (ojo que he tenido que crear ParPareja porque dos parejas no se pueden pasar, solo un objeto vale)
         */

        [OperationContract]
        [System.ServiceModel.Web.WebInvoke(Method = "GET",
            UriTemplate = "TestParPareja")]
        ParPareja TestParPareja();

        [OperationContract]
        [System.ServiceModel.Web.WebInvoke(Method = "GET",
            UriTemplate = "ListaNombres")]
        Dictionary<String,String> ListaNombres();

    }
}
