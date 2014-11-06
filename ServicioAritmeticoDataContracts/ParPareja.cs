using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioAritmeticoDataContracts;

namespace ServicioAritmeticoDataContracts
{
    [Serializable]
    [System.Runtime.Serialization.KnownType(typeof(Pareja))]
    [System.Runtime.Serialization.DataContract(Namespace = "")]
    public class ParPareja
    {
        Pareja a;
        Pareja b;

        public ParPareja() { }


        public ParPareja(Pareja a, Pareja b)
        {
            this.a = a;
            this.b = b;
        }

        [System.Runtime.Serialization.DataMember]
        public Pareja A
        {
            get { return a; }
            set { a = value; }
        }

        [System.Runtime.Serialization.DataMember]
        public Pareja B
        {
            get { return b; }
            set { b = value; }
        }
    }
}
