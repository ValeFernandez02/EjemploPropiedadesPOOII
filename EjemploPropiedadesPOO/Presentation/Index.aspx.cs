using Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Car objCar= new Car();//Creo un objeto de Car
            string msj = objCar.star();//Invocamos el metodo star
            LblMsj1.Text = msj;//Asignamos la variable msj

            Phone objPhone = new Phone();
            string msj1 = objPhone.Star();
            Lblmsj2.Text= msj1;

            Soccer_game objSpccer = new Soccer_game();
            string msj2 = objSpccer.Star();
            Lblmsj3.Text = msj2;
        }
    }
}