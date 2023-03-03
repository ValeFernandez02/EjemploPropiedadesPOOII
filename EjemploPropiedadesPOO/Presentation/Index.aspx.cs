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
            Lblmsj2.Text = msj1;

            Soccer_game objSpccer = new Soccer_game();
            string msj2 = objSpccer.Star();
            Lblmsj3.Text = msj2;

            Laptop objLatop = new Laptop();
            string msj3 = objLatop.Star();
            Lblmsj4.Text = msj3;

            Card objcard = new Card();
            string msj4 = objcard.Star();
            Lblmsj5.Text = msj4;

            Book objbook = new Book();
            string msj5 = objbook.initbook();
            Lblsmj6.Text = msj5;

            person objperson = new person();
            string msj6 = objperson.infoper();
            Lblmsj7.Text = msj6;

            house objhouse = new house();
            string msj7 = objhouse.infohouse();
            Lblmsj8.Text = msj7;


        }
    }
}