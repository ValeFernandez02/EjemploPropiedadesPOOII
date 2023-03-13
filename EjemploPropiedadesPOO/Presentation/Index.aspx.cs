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
    {/*
      * variables globales
      */
        private string color;
        private int model;
        private double gallons;
        private string brand;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                



            Phone objPhone = new Phone();
            objPhone.Model1 = "14 pro max";
            objPhone.Color = "Blanco";
            objPhone.Brand = "Iphone";

            Phone objPhone1 = new Phone();
            objPhone1.Model1 = "xs max";
            objPhone1.Color = "Dorado";
            objPhone1.Brand = "Iphone";

            Phone objPhone2 = new Phone();
            objPhone2.Model1 = "Mi note 10";
            objPhone2.Color = "Azul";
            objPhone2.Brand = "Xiaomi";

            string msj2 = objPhone.Star();
            Lblmsj2.Text = msj2;

            string msj11 = objPhone2.Star();
            Lblmsj11.Text = msj11;

            string msj12 = objPhone2.Star();
            Lblmsj12.Text = msj12;

            Soccer_game objSpccer = new Soccer_game();
            objSpccer.Number_of_players = 11;
            objSpccer.Equipment = "2 equipos";
            objSpccer.Gamer_name = "futboll";
            objSpccer.Game_time = "90 minitos";


            string msj20 = objSpccer.Star();
            Lblmsj20.Text = msj20;

            Laptop objLatop = new Laptop();
            objLatop.Brand = "acer";
            objLatop.Ram = 8;
            objLatop.Size1 = 15.8;
            objLatop.Processor1 = "i core 5";

            string msj4 = objLatop.Star();
            Lblmsj4.Text = msj4;

            Card objcard = new Card();
            objcard.Owner1 = "Andres martinez";
            objcard.Bank = "Bancolombia";
            objcard.Due_date = "21 noviembre 2023";
            objcard.Number = 1088944866;


            string msj5 = objcard.Star();
            Lblmsj5.Text = msj5;

            Book objbook = new Book();
            objbook.Name_book = "Narnia";
            objbook.Pag = 526;
            objbook.Chapters = 10;
            objbook.Date_lounch = "10 de abril 1995";

            string msj6 = objbook.initbook();
            Lblsmj6.Text = msj5;

            person objperson = new person();
            objperson.Coloreyes = "Azul";
            objperson.Ege = 19;
            objperson.Document = 1019012090;
            objperson.Height = 1.58;

            string msj7 = objperson.infoper();
            Lblmsj7.Text = msj7;

            house objhouse = new house();
            objhouse.Room = 5;
            objhouse.Neighborhood = "Brookland";
            objhouse.Bathroom = 4;
            objhouse.Floor = 2;
            string msj8 = objhouse.infohouse();
            Lblmsj8.Text = msj7;


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
            model = Convert.ToInt32( TBModelo.Text);
            gallons = Convert.ToDouble( TBGallons.Text);
            brand = TBBrand.Text;

            Car objCar1 = new Car(color, model, gallons, brand);

            Lblmsj10.Text = objCar1.star();

            LimpiarCajas();
        }

        protected void LBCar_Click(object sender, EventArgs e)
        {
            //Redirecciona al Formulario WFcar
            Response.Redirect("WFCar.aspx");
        }

        protected void LBPhone_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFPhone.aspx");
        }

        protected void LBPerson_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFPerson.aspx");
        }

        protected void LBScoccer_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFSoccer.aspx");
        }

        protected void LBHouse_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WFHouse.aspx");
        }

        protected void LBCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFCard.aspx");
        }

        protected void LBBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFBook.aspx");
        }

        protected void LBLaptop_Click(object sender, EventArgs e)
        {
            Response.Redirect("WFLaptop.aspx");
        }
    }
}