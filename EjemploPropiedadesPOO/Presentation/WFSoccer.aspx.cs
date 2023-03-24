using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFSoccer : System.Web.UI.Page
    {
        private int number_of_players;
        private string game_time;
        private string equipment;
        private string gamer_name;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCajas()
        {
            TBPlayers.Text = " ";
            TBTime.Text = " ";
            TBEquipamet.Text = " ";
            TBName.Text = " ";
        }

        protected void BTEnviar_Click(object sender, EventArgs e)
        {
            number_of_players = Convert.ToInt32(TBPlayers.Text);
            game_time = TBTime.Text;
            equipment = TBEquipamet.Text;
            gamer_name = TBName.Text;

            Soccer_game objScoccer = new Soccer_game(number_of_players, game_time, equipment,gamer_name);
            Lblmsj33.Text = objScoccer.Star();
            LimpiarCajas();
        }
    }
}