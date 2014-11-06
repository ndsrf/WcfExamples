using ServicioAritmeticoDataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceExample
{
    public class ServicioAritmeticoREST : IServicioAritmeticoREST
    {
        public Pareja Sumar(int a, int b, int c, int d)
        {
            return new Pareja(a + c, b + d);
        }

        public Pareja Restar(int a, int b, int c, int d)
        {
            return new Pareja(a - c, b - d);
        }

        public Pareja Sumar(string a, string b, string c, string d)
        {
            return Sumar(int.Parse(a), int.Parse(b), int.Parse(c), int.Parse(d));
        }

        public Pareja Restar(string a, string b, string c, string d)
        {
            return Restar(int.Parse(a), int.Parse(b), int.Parse(c), int.Parse(d));
        }


        public Pareja SumarPost(ParPareja x)
        {
            Pareja a = x.A;
            Pareja b = x.B;

            return new Pareja(a.First + b.First, a.Second + b.Second);
        }


        public ParPareja TestParPareja()
        {
            return new ParPareja(new Pareja(1, 2), new Pareja(10, 20));
        }


        public Dictionary<string, string> ListaNombres()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("JGM", "Javier García Magna");
            dict.Add("ED", "Eri Dimopoulou");
            dict.Add("DGM", "Deborah García Magna");

            return dict;
        }
    }
}
