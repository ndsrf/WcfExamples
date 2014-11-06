using Newtonsoft.Json;
using ServicioAritmeticoDataContracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsClient
{
    class CalculadoraREST : ICalculadora 
    {
        //private const string URL_GET_RESTAR = "http://192.168.1.133:1356/ServicioAritmeticoREST.svc/restarJson/";
        //private const string URL_POST_SUMAR = "http://192.168.1.133:1356/ServicioAritmeticoREST.svc/SumarPost";


        public Pareja Sumar(Pareja a, Pareja b)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Pareja));

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(ConfigurationManager.AppSettings["URL_POST_SUMAR"]);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";

            // Alternativa NewtonSoft
            string json = JsonConvert.SerializeObject(new ParPareja(a, b));

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                //string json = "{\"A\":{\"First\":1,\"Second\":2},\"B\":{\"First\":10,\"Second\":20}}";
                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            Pareja p = (Pareja)ser.ReadObject(httpResponse.GetResponseStream());

            return p;
        }

        public Pareja Restar(Pareja a, Pareja b)
        {
            string strURLComplete = ConfigurationManager.AppSettings["URL_GET_RESTAR"] + a.First + "/" + a.Second + "/" + b.First + "/" + b.Second;

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Pareja));
            //dynamic results = new Uri().GetDynamicJsonObject().;

            Uri uri = new Uri(strURLComplete);

            WebRequest req = WebRequest.Create(uri);
            req.Method = "GET";
            req.ContentType = "application/json; charset=utf-8";
            using (WebResponse wresp = req.GetResponse())
            {
                using (Stream respStream = wresp.GetResponseStream())
                {
                    using (StreamReader objReader = new StreamReader(respStream))
                    {

                        string json = objReader.ReadLine();
                        // {"RestarResult":{"First":330,"Second":4}}

                        Pareja p = JsonConvert.DeserializeObject<Pareja>(json);

                        return p;
                    }
                }
            }

        }

        void DoWithResponse(HttpWebRequest request, Action<HttpWebResponse> responseAction)
        {
            Action wrapperAction = () =>
            {
                request.BeginGetResponse(new AsyncCallback((iar) =>
                {
                    var response = (HttpWebResponse)((HttpWebRequest)iar.AsyncState).EndGetResponse(iar);
                    responseAction(response);
                }), request);
            };
            wrapperAction.BeginInvoke(new AsyncCallback((iar) =>
            {
                var action = (Action)iar.AsyncState;
                action.EndInvoke(iar);
            }), wrapperAction);
        }

        //private string ToJson<T>(/* this */ T value, Encoding encoding)
        //{
        //    var serializer = new DataContractJsonSerializer(typeof(T));

        //    using (var stream = new MemoryStream())
        //    {
        //        using (var writer = JsonReaderWriterFactory.CreateJsonWriter(stream, encoding))
        //        {
        //            serializer.WriteObject(writer, value);
        //        }

        //        return encoding.GetString(stream.ToArray());
        //    }
        //}


        private string Serialize<T>(T obj)
        {
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(obj.GetType());
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, obj);
            string retVal = Encoding.Default.GetString(ms.ToArray());
            ms.Dispose();
            return retVal;
        }

        private T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            ms.Close();
            ms.Dispose();
            return obj;
        }

    }
}
