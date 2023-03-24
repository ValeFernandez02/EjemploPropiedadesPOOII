using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{

    public partial class WFPhone : System.Web.UI.Page
    {
        private string brand;
        private double Series;
        private string color;
        private string model;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
            TBColor.Text = " ";
            TBBrand.Text = " ";
            TBSeries1.Text = " ";
            TBModelo.Text = " ";
        }

        protected void BTEnviar_Click(object sender, EventArgs e)
        {

            brand = TBBrand.Text;
            Series = Convert.ToDouble(TBSeries1.Text);
            color = TBColor.Text;
            model = TBModelo.Text;

            Phone objPhone = new Phone(brand ,Series, color, model) ;
            Lblmsj30.Text = objPhone.Star();
            LimpiarCajas();
        }
    }
}