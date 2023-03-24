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
    public partial class WFCar : System.Web.UI.Page
    {
        private string color;
        private int model;
        private double gallons;
        private string brand;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCajas()
        {
            TBColor.Text = " ";
            TBBrand.Text = " ";
            TBGallons.Text = " ";
            TBModelo.Text = " ";
        }

        protected void BTEnviar_Click(object sender, EventArgs e)
        {
            color = TBColor.Text;
            model = Convert.ToInt32(TBModelo.Text);
            gallons = Convert.ToDouble(TBGallons.Text);
            brand = TBBrand.Text;

            Car objCar1 = new Car(color, model, gallons, brand);

            Lblmsj10.Text = objCar1.star();

            LimpiarCajas();
        }
    }
}