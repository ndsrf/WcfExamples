using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioAritmeticoDataContracts
{

    [System.Runtime.Serialization.DataContract]
    public class Pareja
    {

        int m_first;
        int m_second;

        public Pareja()
        {
            m_first = 0;
            m_second = 0;
        }

        public Pareja(int first, int second)
        {
            m_first = first;
            m_second = second;
        }

        [System.Runtime.Serialization.DataMember]
        public int First
        {
            get { return m_first; }
            set { m_first = value; }
        }

        [System.Runtime.Serialization.DataMember]
        public int Second
        {
            get { return m_second; }
            set { m_second = value; }
        }
    }
}