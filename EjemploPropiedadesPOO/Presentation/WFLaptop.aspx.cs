using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFLaptop : System.Web.UI.Page
    {
        private string brand;
        private string processor;
        private double size;
        private int ram;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
            TBMarca.Text = " ";
            TBProcesador.Text = " ";
            TBTamaño.Text = " ";
            TBRam.Text = " ";
        }

        protected void BTEnviar_Click(object sender, EventArgs e)
        {
            brand = TBMarca.Text;
            processor = TBProcesador.Text;
            size = Convert.ToDouble( TBTamaño.Text);
            ram = Convert.ToInt32(TBRam.Text);

            Laptop objLaptop = new Laptop(brand,processor,size,ram);
            Lblmsj36.Text = objLaptop.Star();
            LimpiarCajas();

        }

        }
    }
