using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioAritmeticoDataContracts;

namespace WinFormsClient
{
    class Calculadora : ICalculadora
    {
        private readonly ICalculadora calc;

        public Calculadora()
        {
            UnityServiceLocator locator = new UnityServiceLocator(CreateConfiguredUnityContainer());
            ServiceLocator.SetLocatorProvider(() => locator);

            calc = ServiceLocator.Current.GetInstance<ICalculadora>();
        }

        private static IUnityContainer CreateConfiguredUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

            // provide default mappings programmatically
            //container.RegisterType<ICustomService, CustomServiceImpl2>();

            // OR... load static config from the *.xml file
            container.LoadConfiguration("ProveedorAritmetico");

            return container;
        }

        public Calculadora(ICalculadora c)
        {
            calc = c;
        }

        public Pareja Sumar(Pareja a, Pareja b)
        {
            return calc.Sumar(a, b);
        }

        public Pareja Restar(Pareja a, Pareja b)
        {
            return calc.Restar(a, b);
        }
    }
}
