using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFCard : System.Web.UI.Page
    {
        private string bank;
        private double number;
        private string owner;
        private string due_data;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
            TBBank.Text = " ";
            TBNumber.Text = " ";
            TBOwner.Text = " ";
            TBData.Text = " ";
        }
        protected void BTEnviar_Click(object sender, EventArgs e)
        {
            bank = TBBank.Text;
            number =Convert.ToInt32(TBNumber.Text);
            owner = TBOwner.Text;
            due_data = TBData.Text;

            Card ObjCard = new Card(bank,number,owner,due_data);
            Lblmsj34.Text = ObjCard.Star();
            LimpiarCajas();

        }
    }
}