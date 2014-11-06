using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicioAritmeticoDataContracts;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        ICalculadora proveedorCalculos;

        public Form1()
        {
            InitializeComponent();

            proveedorCalculos = new Calculadora();
        }

        private void ExtraerDatos(out Pareja a, out Pareja b)
        {
            int valor1, valor2;
            bool conversionOk;

            conversionOk = int.TryParse(txtPar11.Text, out valor1);
            conversionOk = int.TryParse(txtPar12.Text, out valor2);

            a = new Pareja();
            a.First = valor1;
            a.Second = valor2;

            conversionOk = int.TryParse(txtPar21.Text, out valor1);
            conversionOk = int.TryParse(txtPar22.Text, out valor2);

            b = new Pareja();
            b.First = valor1;
            b.Second = valor2;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Pareja a, b;

            ExtraerDatos(out a, out b);

            Pareja c = proveedorCalculos.Sumar(a, b);

            PublicarDatos(c);
        }

        private void PublicarDatos(Pareja c)
        {
             txtRes1.Text = c.First.ToString();
             txtRes2.Text = c.Second.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Pareja a, b;

            ExtraerDatos(out a, out b);

            Pareja c = proveedorCalculos.Restar(a, b);

            PublicarDatos(c);
        }
    }
}
