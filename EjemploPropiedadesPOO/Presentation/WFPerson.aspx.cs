using Logic.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFPerson : System.Web.UI.Page
    {
        private string nombre;
        private string apellido;
        private string document;
        private string tipoContrato;
        private int sueldo;
        //private double height;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
        TBNombres.Text = " ";
        TBApellidos.Text = " ";
        TBDocument.Text = " ";
        //TBHeight.Text = " ";
        }
        protected void BTEnviar_Click(object sender, EventArgs e)
        {
            string mensaje;
            nombre = TBNombres.Text;
            apellido= TBApellidos.Text;
            document = TBDocument.Text;
            sueldo = Convert.ToInt32(sueldo);
            tipoContrato = DDLTipoContrato.Text;
            //height = Convert.ToDouble(TBHeight.Text);

            Employee objEmployee = new Employee(nombre, apellido, document, tipoContrato, sueldo);
            mensaje = objEmployee.bonoEmpleado();
            LblMensaje.Text = mensaje;
            //person objperson = new person(nombre,apellido,document);
            //Lblmsj31.Text = objperson.doc();
            LimpiarCajas();

        }
    }
}