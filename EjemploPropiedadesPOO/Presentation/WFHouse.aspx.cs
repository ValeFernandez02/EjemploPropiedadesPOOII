using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFHouse : System.Web.UI.Page
    {
        private int room;
        private string neighborhood;
        private int bathroom;
        private int floor;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
            TBHabitaciones.Text = " ";
            TBBarrio.Text = " ";
            TBBaños.Text = " ";
            TBPisos.Text = " ";
        }

        protected void BTEnviar_Click(object sender, EventArgs e)
        {
            room = Convert.ToInt32( TBHabitaciones.Text);
            neighborhood = TBBarrio.Text;
            bathroom = Convert.ToInt32( TBBaños.Text );
            floor = Convert.ToInt32( TBPisos.Text );

            house objhouse = new house(room, neighborhood, bathroom, floor);
            Lblmsj37.Text = objhouse.infohouse();
            LimpiarCajas();
        }
    }
}