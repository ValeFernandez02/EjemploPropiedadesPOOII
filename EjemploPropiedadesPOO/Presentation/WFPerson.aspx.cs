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
        private string coloreyes;
        private int ege;
        private int document;
        private double height;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
        TBEyes.Text = " ";
        TBEge.Text = " ";
        TBDocument.Text = " ";
        TBHeight.Text = " ";
        }
        protected void BTEnviar_Click(object sender, EventArgs e)
        {
            coloreyes = TBEyes.Text;
            ege=Convert.ToInt32(TBEge.Text);
            document = Convert.ToInt32(TBDocument.Text);
            height = Convert.ToDouble(TBHeight.Text);

            person objperson = new person(coloreyes, ege,document,height);
            Lblmsj31.Text = objperson.infoper();
            LimpiarCajas();

        }
    }
}